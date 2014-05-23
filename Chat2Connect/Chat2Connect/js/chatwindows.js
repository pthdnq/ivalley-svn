﻿
function Chat(maxWin, memberID, memberName) {
    var self = this;
    self.CurrentMemberID = memberID;
    self.CurrentMemberName = memberName;
    self.maxRoom = ko.observable(maxWin);
    self.windows = ko.observableArray();
    self.Editor = null;
    self.selectedGift = null;
    // init gifts object    
    
    self.notTempRoom = ko.computed(function () {
        return ko.utils.arrayFilter(self.windows(), function (win) {
            return win.IsTemp() == false && win.Type() == "Room";
        });
    }, self);
    self.allRooms = ko.computed(function () {
        return ko.utils.arrayFilter(self.windows(), function (win) {
            return win.Type() == "Room";
        });
    }, self);
    self.getWindow = function (id, type, name) {
        var window = ko.utils.arrayFirst(self.windows(), function (win) {
            return win.ID() == id && win.Type() == type;
        });
        if (window == null) {
            if (type == "Private") {
                chatVM.addWindow(id, name, type);
				// generated id for private chat
                //var newroomid = (id < self.CurrentMemberID) ? id + "_" + self.CurrentMemberID : self.CurrentMemberID + "_" + id;
                //window = chatVM.getWindow(newroomid, type);
                window = chatVM.getWindow(id, type);
            }
        }
        return window;
    }
    var mapping = {
        '': {
            create: function (options) {
                return new windowModel(options.data);
            }
        }
    }
    var windowModel = function (data) {
        ko.mapping.fromJS(data, {}, this);

        this.uniqueID = ko.computed(function () {
            return this.Type() + '_' + this.ID();
        }, this);

        //Room Members
        this.getMember = function (id) {
            return ko.utils.arrayFirst(this.RoomMembers(), function (mem) {
                return mem.MemberID() == id;
            });
        }
        this.addMember = function (member) {
            this.RoomMembers.push(member);
            
        };
        this.newMember = function (id, name, memberType) {
            var member = { MemberID: id, MemberName: name, MemberTypeID: memberType, IsCamOpened: false, IsMicOpened: false };
            return ko.mapping.fromJS(member);
        }
        this.removeMember = function (id) {
            var member = this.getMember(id);
            if (member != null) {
                this.RoomMembers.remove(member);
                
            }
        };
        //Queue Members
        this.getQueueMember = function (id) {
            return ko.utils.arrayFirst(this.QueueMembers(), function (mem) {
                return mem.MemberID() == id;
            });
        }
        this.addQueueMember = function (member) {
            if (member == null)
                return;
            this.QueueMembers.push(member);
        };
        this.removeQueueMember = function (id) {
            var member = this.getQueueMember(id);
            if (member != null) {
                this.QueueMembers.remove(member);
            }
        };

        this.updateSetting = function (settingName) {
            var window = this;
            var newValue = !window.CurrentMemberSettings[settingName]();
            window.CurrentMemberSettings[settingName](newValue);
            $.ajax({
                url: '../Services/Services.asmx/UpdateRoomSetting',
                dataType: 'json',
                type: 'post',
                data: "{'mid':" + self.CurrentMemberID + ", 'rid' : " + window.ID() + ",'setting':'" + settingName + "','newValue':"+newValue+" }",
                contentType: 'application/json; charset=utf-8',
                success: function (data) {
                    notify('success', 'تم تغيير الإعدادات بنجاح');
                    return;

                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    $.pnotify({
                        text: 'حدث خطأ . من فضلك أعد المحاولة.',
                        type: 'error',
                        history: false,
                        closer_hover: false,
                        delay: 5000,
                        sticker: false
                    });
                }
            });
            return true;
        }
        var self = this;
        this.banMember = function (id) {
            var member = self.getMember(id);
            if (member == null)
                member = self.getQueueMember(id);
            if (member == null)
                return;

            //self.bannedMember().MemberName(member.MemberName());
            //self.bannedMember().MemberID(member.MemberID());
            var banned = self.getMemberSetting(id);
            self.bannedMember(banned);
            $("#banModal_" + self.uniqueID() ).modal('show');
        };
        this.saveBanMember = function () {
            var window = this;
            $.ajax({
                url: '../Services/Services.asmx/BanRoomMember',
                dataType: 'json',
                type: 'post',
                data: "{'memberID':" + window.bannedMember().MemberID() + ", 'roomID' : " + window.ID() + ",'type':'" + window.bannedType() + "','adminID':"+chatVM.CurrentMemberID+"}",
                contentType: 'application/json; charset=utf-8',
                success: function (data) {
                    notify('success', 'تم حجب العضو بنجاح');
                    $("#banModal_" + window.uniqueID()).modal('hide');
                    rHub.server.banMemberFromRoom(window.bannedMember().MemberID(), window.ID(), window.bannedType(), chatVM.CurrentMemberName);
                    window.bannedMember().BanType(window.bannedType());
                    window.bannedMember().IsMemberBanned(true);
                    return;
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    $("#banModal_" + window.uniqueID()).modal('hide');
                    $.pnotify({
                        text: 'حدث خطأ . من فضلك أعد المحاولة.',
                        type: 'error',
                        history: false,
                        closer_hover: false,
                        delay: 5000,
                        sticker: false
                    });
                }
            });
        };
        //this.bannedMember = new banMemberModel(this.newMember(0, ""));
        //control panel
        this.BannedMembers = ko.computed(function () {
            return ko.utils.arrayFilter(self.AllMembersSettings(), function (mem) {
                return mem.IsMemberBanned();
            });
        }, this);
        this.NotBannedMembers = ko.computed(function () {
            return ko.utils.arrayFilter(self.AllMembersSettings(), function (mem) {
                return !mem.IsMemberBanned() && mem.MemberID()!=chatVM.CurrentMemberID;
            });
        }, this);
        this.bannedMember = ko.observable();
        this.bannedType = ko.observable();
        this.showControlPanel = function () {
            var window = this;
            $("#controlPanelModal_" + window.uniqueID()).modal('show');
        };
        this.removeSelectedBannedType = function (type)
        {
            var bannedMembers = [];
            $('#' + type).each(function (i, selected) {
                var id;
                if (this.options == undefined)
                    id = $(this).val();
                else
                    id = $(this.options[i]).val();
                var member = self.getMemberSetting(id);
                if (member != null)
                {
                    member.BanType(null);
                    member.IsMemberBanned(false);
                    bannedMembers[i] = id;
                }
                
            });
            if (bannedMembers.length > 0)
            {
                $.ajax({
                    url: '../Services/Services.asmx/RemoveBanningFromRoomMembers',
                    type: 'GET',
                    traditional: true,
                    data: { membersID: bannedMembers, roomID: self.ID() },
                    success: function (result) {
                        notify('success', 'تم حذف الحجب بنجاح');
                    }
                });
            }
        }
        
        this.getMemberSetting = function (mid) {
            var member = ko.utils.arrayFirst(self.AllMembersSettings(), function (mem) {
                    return mem.MemberID() == mid;
            });
            return member;
        };
        this.saveRoomTopic=function()
        {
            var window = this;
            rHub.server.updateRoomTopic(window.ID(), window.RoomTopic());
        }
        // invite friends
        this.ShowInviteFriends = function () {
            $("#inviteModal_" + self.uniqueID()).modal('show');
        };

        this.Invitefriends = function () {
            var window = this;
            $.ajax({
                url: '../Services/Services.asmx/InviteFriends',
                dataType: 'json',
                type: 'post',
                data: "{'memberName':'" + chatVM.CurrentMemberName + "', 'roomID' : " + window.ID() + ", 'roomName' :'"+ window.Name() +"','friendsIDs':'" + $('#invite_' + window.uniqueID()).val() + "'}",
                contentType: 'application/json; charset=utf-8',
                success: function (data) {
                    notify('success', 'تم دعوة الأصدقاء بنجاح');
                    $("#inviteModal_" + window.uniqueID()).modal('hide');                    
                    return;
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    $("#inviteModal_" + window.uniqueID()).modal('hide');
                    notify('error', 'حدث خطأ . من فضلك أعد المحاولة.');
                }
            });
        };

        // send gifts to friends
        this.ShowSendGift = function () {
            $("#giftModal_" + self.uniqueID()).modal('show');
        };

        this.selectGift = function () {
            chatVM.selectedGift = this;
            $('#gift_' + chatVM.selectedGift.giftid()).parent().parent().find('label').removeClass('selected');
            $('#gift_' + chatVM.selectedGift.giftid()).next('label').addClass('selected');

        };

        this.SendGift = function () {
            var window = this;
            $.ajax({
                url: '../Services/Services.asmx/SendGift',
                dataType: 'json',
                type: 'post',
                data: "{'memberName':'" + chatVM.CurrentMemberName + "', 'roomID' : " + window.ID() + ", 'roomName' :'" + window.Name() + "','friendID':'" + $('#gift_' + window.uniqueID()).val() + "', 'friendName':'" + $("#gift_" + window.uniqueID()).tokenInput("get")[0].name + "', 'giftid':" + chatVM.selectedGift.giftid() + "}",
                contentType: 'application/json; charset=utf-8',
                success: function (data) {
                    $("#giftModal_" + window.uniqueID()).modal('hide');
                    notify('success', 'تم إرسال الهدية بنجاح');                    
                    return;
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) {
                    $("#giftModal_" + window.uniqueID()).modal('hide');
                    notify('error', 'حدث خطأ . من فضلك أعد المحاولة.');                    
                }
            });
        };


        // attach
        this.ShowAttachFiles = function () {
            $("#attachModal_" + self.uniqueID()).modal('show');
        };
        
    }
    var banMemberModel=function(member)
    {
        var baned = { MemberID: member.MemberID(), MemberName: member.MemberName(), Type:4};
        return ko.mapping.fromJS(baned);
    }

    self.changeCurrent = function (selctor) {
        if (document.getElementById(selctor)) {
            $('#MainTabs a[href="#' + selctor + '"]').tab('show');
            return;
        }
    };
    self.openWindow = function (id, name, type) {
        var window = self.getWindow(id, type, name);
        if (window == undefined) {
            self.addWindow(id, name, type);
        }
    };
    self.addWindow = function (id, name, type) {
        if (type == 'Private') {
            //var room = { ID: id, Name: name, Type: type, IsTemp: true, Message: "", MessageHistory: "", CurrentMemberSettings: { MemberID: self.CurrentMemberID } };
            //var roomid = (id < self.CurrentMemberID) ? id + "_" + self.CurrentMemberID : self.CurrentMemberID + "_" + id;
            var gifts = null;
             $.post("../services/Services.asmx/GetGifts")
                .done(function (data) {
                    //console.log(data);
                    gifts = data;                    
                });

			var room = { ID: id, Name: name, RoomTopic:"", Type: type, IsTemp: true, Message: "", MessageHistory: "", CurrentMemberSettings: { MemberID: self.CurrentMemberID, IsMicOpened: false, IsCamOpened: false, CanAccessCam: true, CanAccessMic: true, CanWrite: true }, Settings: { EnableCam: true, EnableMic: true, MaxMic: 2, CamCount: 2 }, RoomMembers: {}, QueueMembers: {}, MicMember:{}, AllMembersSettings:[] , Gifts:gifts};
            var win = ko.mapping.fromJS(room, mapping);
            self.windows.push(win);
            self.changeCurrent(win.uniqueID());
            self.Init(win);
            rHub.server.enterPrivateChatLog(id, name);
        }
        else {
            if (self.notTempRoom().length == self.maxRoom()) {
                $.pnotify({
                    text: 'عفواً ، لقد قمت بدخول العدد الأقصى من الغرف فى نفس الوقت.',
                    type: 'error',
                    history: false,
                    closer_hover: false,
                    delay: 5000,
                    sticker: false
                });
                return;
            }
            $.post("../services/Services.asmx/GetChatRoom", { id: id, isTemp: false })
                .done(function (data) {
                    if (data.Status!=1)
                    {
                        notify('error', data.Data);
                        return;
                    }
                    var win = ko.mapping.fromJS(data.Data, mapping);
                    self.windows.push(win);
                    self.changeCurrent(win.uniqueID());
                    rHub.server.addToRoom(id);
                    self.Init(win);
                });
        }

    }
    self.removeWindow = function () {
        if (this.Type() == "Room") {
            rHub.server.removeFromRoom(this.ID());
        }
        self.windows.remove(this);
        $('.nav-tabs a:last').tab('show');
    }
    self.rateRoom = function (val) {
        var room = this;
        RateRoom(room.ID(), val);
        room.CurrentMemberSettings.UserRate(val);
        return true;
    }
    self.sendMessage = function (window) {
        if (window == null)
            window = this;
        if (window.Type() == "Room") {
            //rHub.server.sendToRoom(window.ID(), self.CurrentMemberName, window.Message());
            rHub.server.sendToRoom(window.ID(), self.CurrentMemberName, self.Editor.getValue());
        }
        else {
            //rHub.server.sendPrivateMessage(window.ID(), window.Message());
            rHub.server.sendPrivateMessage(window.ID(), self.Editor.getValue());
        }
        //window.Message("");
        self.Editor.setValue("");
    }

    self.toggleFlashObj = function (window) {
        
        if ($('#chat2connect_' + window.uniqueID()).css('height') == '0px')
            $('#chat2connect_' + window.uniqueID()).css('height', '180px');
        else
            $('#chat2connect_' + window.uniqueID()).css('height', '0px');
        return true;
    }
    
    // init html Editor 
    // tooltips for toolbar
    // scroll bars
    self.Init = function (window) {
        self.Editor = new wysihtml5.Editor('uiTextMsg_' + window.uniqueID(), { toolbar: 'toolbar' + window.uniqueID(), parserRules: wysihtml5ParserRules, useLineBreaks: false, stylesheets: 'css/main.css' });
        if (!window.CurrentMemberSettings.CanWrite())
            self.Editor.disable();
        // apply enter key listener
        self.Editor.observe('load', function () {
            self.Editor.composer.element.addEventListener('keyup', function (e) {
                if (e.which == 13) {
                    e.preventDefault();
                    self.sendMessage(window);
                }
            });
        });

        // tooltips 
        $(".roomMenuItem").tooltip();

        // apply scroll to all
        $('.SScroll').each(function () {
            $(this).slimScroll({
                railVisible: true,
                height: $(this).attr('data-height'),
                color: '#FEC401',
                railColor: '#C7C5C0',
                position: 'left'
            });
        });

        // token input for invite members
        $("#invite_" + window.uniqueID()).tokenInput("Services/Services.asmx/SearchMembersFriends?memberID=" + self.CurrentMemberID, {
            theme: "facebook",
            preventDuplicates: true,
            hintText: "",
            noResultsText: "لا يوجد",
            searchingText: "بحث فى الأصدقاء..."
        });

        // token input for send gifts
        $("#gift_" + window.uniqueID()).tokenInput("Services/Services.asmx/SearchMembersFriends?memberID=" + self.CurrentMemberID, {
            theme: "facebook",
            preventDuplicates: true,
            hintText: "",
            noResultsText: "لا يوجد",
            searchingText: "بحث فى الأصدقاء...",
            tokenLimit: 1
        });


        // volume controls       

        $('#uiListenVolume_' + window.uniqueID()).slider()
          .on('slide', function(ev){
              self.setListenVolume(window, $('#uiListenVolume_' + window.uniqueID()).data('slider').getValue());
          });
        $('#uiMicVolume_' + window.uniqueID()).slider()
         .on('slide', function (ev) {
             self.setListenVolume(window, $('#uiMicVolume_' + window.uniqueID()).data('slider').getValue());
         });


        // attach files
        new AjaxUpload('#UploadButton_' + window.uniqueID() , {
            action: '../services/FileUploader.ashx',
            onComplete: function (file, response) {
                $('<div><img src="../images/btndelete.png" onclick="DeleteFile('+ response + "')' class='delete'/>" + response + '</div>').appendTo('#UploadedFile_' + window.uniqueID());
                $('#UploadStatus_' + window.uniqueID()).html('تم رفع الصورة بنجاح');
                $('#UploadButton_' + window.uniqueID()).hide();
            },
            onSubmit: function (file, ext) {
                if (!(ext && /^(png|gif|jpg)$/i.test(ext))) {
                    alert('حدث خطأ . تأكد من نوع ملف الصورة');
                    return false;
                }
                $('#UploadStatus_' + window.uniqueID()).html('جارى التحميل...');
            }
        });

        // popover menu for members
        /*$('.roomMemberlink').each(function () {
            var $this = $(this);
            $this.popover({
                trigger: 'click',
                placement: 'left',
                html: true,
                content: $this.find('.friendSubMenu').html(),
                container: '#' + window.uniqueID()
            });
        });*/

        

    };

    self.removeMember = function (mid) {
        ko.utils.arrayForEach(self.allRooms(), function (room) {
            room.removeMember(mid);
            room.removeQueueMember(mid);
        });
    };
    self.requestMic = function () {
        var currentWindow = this;
        $.ajax({
            url: '../Services/Services.asmx/GetQueueOrder',
            dataType: 'json',
            type: 'post',
            data: "{'memberID':'" + self.CurrentMemberID + "', 'roomID' : '" + currentWindow.ID() + "' }",
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                if (data.d > 0) {
                    //move from roomMembers to queueMembers
                    var member = currentWindow.getMember(self.CurrentMemberID);
                    currentWindow.addQueueMember(member);
                    currentWindow.removeMember(self.CurrentMemberID);
                    rHub.server.userRaisHand(currentWindow.ID(), self.CurrentMemberID);
                }
                else {
                    //move from queueMembers to roomMembers
                    var member = currentWindow.getQueueMember(self.CurrentMemberID);
                    currentWindow.addMember(member);
                    currentWindow.removeQueueMember(self.CurrentMemberID);
                    rHub.server.userDownHand(currentWindow.ID(), self.CurrentMemberID);
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                $.pnotify({
                    text: 'حدث خطأ . من فضلك أعد المحاولة.',
                    type: 'error',
                    history: false,
                    closer_hover: false,
                    delay: 5000,
                    sticker: false
                });
            }
        });
    }
    self.mic = function () {
        var currentWindow = this;
        if (currentWindow.CurrentMemberSettings.IsMicOpened() == false) {
            self.startMic(currentWindow, self.CurrentMemberID);
            //currentWindow.NoOfMics(currentWindow.NoOfMics() + 1);
            //set current member as micMember
            var member = currentWindow.getQueueMember(self.CurrentMemberID);
            if (member != null) {
                currentWindow.removeQueueMember(self.CurrentMemberID);
                currentWindow.MicMember(member);
            }
            currentWindow.CurrentMemberSettings.IsMicOpened(true);
        }
        else {
            self.stopMic(currentWindow, self.CurrentMemberID);
            //currentWindow.NoOfMics(currentWindow.NoOfMics() - 1);
            var micMember = currentWindow.MicMember();//remove from mic member to room members
            if (micMember != null) {
                currentWindow.addMember(micMember.MemberID(), micMember.MemberName());
                currentWindow.MicMember(null);
            }
            currentWindow.CurrentMemberSettings.IsMicOpened(false);
        }
    }
    self.startMic = function (window, memberid) {
        var member = window.getMember(memberid);
        if (member == null)
            member = window.getQueueMember(memberid);
        if (member != null) {
            member.IsMicOpened(true);
            
            getFlashMovie('chat2connect_' + window.uniqueID()).startMic(memberid);
            if (self.CurrentMemberID == memberid) {
                rHub.server.userStartMic(window.ID(), memberid);
            }
            else
            {
                if (window.CurrentMemberSettings.NotifyOnMicOn()) {
                    notify('info', 'العضو ' + member.MemberName() + ' أخذ المايك');
                }
            }
        }
    }
    self.stopMic = function (window, memberid) {
        var member = window.getMember(memberid);
        if (member == null)
            member = window.getQueueMember(memberid);
        if (member != null) {
            member.IsMicOpened(false);
            
            getFlashMovie('chat2connect_' + window.uniqueID()).stopMic(memberid);
            if (self.CurrentMemberID == memberid)
                rHub.server.userStopMic(window.ID(), memberid)
            else
            {
                if (window.CurrentMemberSettings.NotifyOnMicOff()) {
                    notify('info', 'العضو ' + member.MemberName() + ' ترك المايك');
                }
            }
        }
        //$('#Room_5 #roomMembersDiv #m_6 .controls .mic').css('display', 'none');
    }

    self.cam = function () {
        var currentWindow = this;
        if (currentWindow.CurrentMemberSettings.IsCamOpened() == false) {
            self.startCam(currentWindow, self.CurrentMemberID, self.CurrentMemberName);
            currentWindow.CurrentMemberSettings.IsCamOpened(true);
        }
        else {
            self.stopCam(currentWindow, self.CurrentMemberID);
            currentWindow.CurrentMemberSettings.IsCamOpened(false);
        }
    }
    self.startCam = function (window, memberID, memberName) {
        getFlashMovie('chat2connect_' + window.uniqueID()).startCam(memberID, memberName);
        if (self.CurrentMemberID == memberID) {
            rHub.server.userStartCam(window.ID(), self.CurrentMemberID);
            // $('#Room_5 #roomMembersDiv #m_6 .controls .camera').css('display', 'inline-block');
        }
    }
    self.stopCam = function (window, memberID) {
        getFlashMovie('chat2connect_' + window.uniqueID()).stopCam(memberID);
        if (self.CurrentMemberID == memberID) {
            rHub.server.userStopCam(window.ID(), self.CurrentMemberID);
            //$('#Room_5 #roomMembersDiv #m_6 .controls .camera').css('display', 'none');
        }
    }

    // set the playback volume (volume value is from 0 to 1)
    self.setListenVolume = function setPlaybackVolume(window,volume) {
        getFlashMovie('chat2connect_' + window.uniqueID()).setPlaybackVolume(volume/10.0);
    }
    
}

function onCamClose(userId, roomId)
{
    var window = chatVM.getWindow(roomId.substr(roomId.indexOf("_") + 1), 'Room');
    if (window == null)
        return;
    chatVM.stopCam(window, userId);
}

function addChatRoom(id, name, type) {
    if (chatVM == undefined)
        InitChat(100);
    chatVM.openWindow(id, name, type);
}

function getFlashMovie(movieName) {
    return document[movieName] || window[movieName];
}
var chatVM;
function InitChat(maxWinRooms, memberID, memberName) {
    chatVM = new Chat(maxWinRooms, memberID, memberName);
    ko.applyBindings(chatVM);

    /****** signalR ********/
    function addMsgToWindow(window, msg, css) {
        msg = "<br><div class='pull-left "+css+"' style='width:auto;margin-right:5px;'>" + msg + "</div>";
        window.MessageHistory(window.MessageHistory() + msg);
        $(".MsgHistroy").slimScroll({
            railVisible: true,
            height: '400px',
            color: '#FEC401',
            railColor: '#C7C5C0',
            position: 'left',
            scrollTo: $(".MsgHistroy", "#" + window.uniqueID()).height()
        });
    }
    rHub = $.connection.chatRoomHub;
    rHub.client.getPrivateMessage = function (fromId, fromUserName, message) {
        var window = chatVM.getWindow(fromId, "Private", fromUserName);

        var history = window.MessageHistory();
        var newMsg = "<div class='pull-left' style='width:auto;margin-right:5px;'><b>" + fromUserName + "</b></div><div class='pull-left'><b>:</b></div><div class='pull-left' style='width:auto;'> " + message + "</div><div style='clear:both;height:1px;'></div>";
        window.MessageHistory(history + newMsg);
        $(".MsgHistroy").slimScroll({
            railVisible: true,
            height: '400px',
            color: '#FEC401',
            railColor: '#C7C5C0',
            position: 'left',
            scrollTo: $(".MsgHistroy", "#" + window.uniqueID()).height()
        });
    };
    rHub.client.getMessage = function (rid, sname, msg) {
        var type = "Room";
        var window = chatVM.getWindow(rid, type, sname);
        if (window == null)
            return;
        var history = window.MessageHistory();
        var newMsg = "<div class='pull-left' style='width:auto;margin-right:5px;'><b>" + sname + "</b></div><div class='pull-left'><b>:</b></div><div class='pull-left' style='width:auto;'> " + msg + "</div><div style='clear:both;height:1px;'></div>";
        window.MessageHistory(history + newMsg);
        $(".MsgHistroy").slimScroll({
            railVisible: true,
            height: '400px',
            color: '#FEC401',
            railColor: '#C7C5C0',
            position: 'left',
            scrollTo: $(".MsgHistroy", "#" + window.uniqueID()).height()
        });
        // update save link 
        //SaveConversation(rid);
    };
    rHub.client.getVideoMessage = function (rid, sname, url) {
        var arr = url.split('v='); // remove "youtube.com/watch?v="
        var id = arr[1].split('&'); // extract vedio id from query string - first element in the array

        var type = "Room";
        var window = chatVM.getWindow(rid, type, sname);
        if (window == null)
            return;
        var history = window.MessageHistory();
        var newMsg = "<div class='pull-left' style='width:auto;margin-right:5px;'><b>" + sname + "</b></div><div class='pull-left'><b>:</b></div><div class='pull-left' style='width:auto;'><a href='" + url + "' target='_blank'><img src='http://img.youtube.com/vi/" + id[0] + "/0.jpg' style='max-width:120px;' /></div><div style='clear:both;height:1px;'></div>";
        window.MessageHistory(history + newMsg);
        $(".MsgHistroy").slimScroll({
            railVisible: true,
            height: '400px',
            color: '#FEC401',
            railColor: '#C7C5C0',
            position: 'left',
            scrollTo: $(".MsgHistroy", "#" + window.uniqueID()).height()
        });

    };
    rHub.client.addNewMember = function (mid, name, rid, memberType) {
        var type = "Room";
        var window = chatVM.getWindow(rid, type, name);
        if (window == null)
            return;
        var member = window.getMember(mid);
        if (member == null)
            member = window.getQueueMember(mid);
        if (member != null)
            return;
        member = window.newMember(mid, name, memberType);
        window.addMember(member);
        if (window.CurrentMemberSettings.NotifyOnFriendsLogOn()) {
            var msg= '' + member.MemberName() + 'قد إنضم للغرفة ';
            addMsgToWindow(window,msg,"joinalert");
        }
    };
    rHub.client.removeMember = function (mid, roomId) {
        var window = chatVM.getWindow(roomId, "Room", "");
        if (window == null)
            return;
        var member = window.getMember(mid);
        if (member == null) {
            member = window.getQueueMember(mid);
            window.removeQueueMember(mid);
        }
        else
            window.removeMember(mid);

        if (member == null)
            return;
        if (window.CurrentMemberSettings.NotifyOnFriendsLogOff()) {
            var msg=member.MemberName() + ' خرج من الغرفة ';
            addMsgToWindow(window,msg,"leftalert");
        }
        if(mid==chatVM.CurrentMemberID)
        {
            chatVM.windows.remove(window);
        }
    };
    function banMemberFromroom(mid, roomId,banTypeName,adminName) {
        var window = chatVM.getWindow(roomId, "Room", "");
        if (window == null)
            return;
        var member = window.getMember(mid);
        if (member == null) {
            member = window.getQueueMember(mid);
            window.removeQueueMember(mid);
        }
        else
            window.removeMember(mid);

        if (member == null)
            return;

        if (chatVM.CurrentMemberID == mid) {
            notify('error', ' تم طردك '+banTypeName+' من الغرفة ' + window.Name() + ' عن طريق الادمن '+adminName);
            chatVM.windows.remove(window);
            $('.nav-tabs a:last').tab('show');
        }
        else
        {
            var msg = 'تم طرد العضو '+member.MemberName()+' '+banTypeName+' من قبل '+adminName+'';
            addMsgToWindow(window, msg, "banalert");
            //if (window.CurrentMemberSettings.NotifyOnFriendsLogOff()) {
            //    notify('info', msg+' من الغرفة '+window.Name());
            //}
        }
    }
    rHub.client.banMemberFromRoom = function (mid, roomId,banTypeName,adminName) {
        banMemberFromroom(mid, roomId, banTypeName, adminName);
    };
    rHub.client.updateRoomTopic = function (roomID, topic) {
        var type = "Room";
        var window = chatVM.getWindow(roomID, type);
        if (window == null)
            return;
        window.RoomTopic(topic);
    }

    rHub.client.ListenMic = function (memberid, rid) {
        /* var fn = window[listenmic];
         var fnparams = [memberid];
         if (typeof fn === 'function') {
             fn.apply(null, fnparams);
         }*/
        var type = "Room";
        var window = chatVM.getWindow(rid, type);
        if (window == null)
            return;

        chatVM.startMic(window, memberid);
        /*$("#Room_" + rid + " #roomMembersDiv #m_" + memberid + " .controls .hand").css('display', 'none');
        $("#Room_" + rid + " #roomMembersDiv #m_" + memberid + " .controls .mic").css('display', 'inline-block');
        $("#Room_" + rid + " #roomMembersDiv #queueDiv #m_" + memberid).appendTo("#Room_" + rid + " #roomMembersDiv #MicDiv");*/
    };

    rHub.client.StopListenMic = function (memberid, rid) {
        var type = "Room";
        var window = chatVM.getWindow(rid, type);
        if (window == null)
            return;

        chatVM.stopMic(window, memberid);

       /* $("#Room_" + rid + " #roomMembersDiv #m_" + memberid + " .controls .mic").css('display', 'none');
        $("#Room_" + rid + " #roomMembersDiv #MicDiv #m_" + memberid).appendTo("#Room_" + rid + " #roomMembersDiv #regular");*/
    };

    rHub.client.UserRaisHand = function (rid, memberid) {
        var window = chatVM.getWindow(rid, "Room");
        if (window != null) {
            var member = window.getMember(memberid);
            if (member != null) {
                window.removeMember(memberid);
                window.addQueueMember(member);
            }
        }
    };

    rHub.client.UserDownHand = function (rid, memberid) {
        var window = chatVM.getWindow(rid, "Room");
        if (window != null) {
            var member = window.getQueueMember(memberid);
            if (member != null) {
                window.removeQueueMember(memberid);
                window.addMember(member);
            }
        }
    };

    rHub.client.UserMarked = function (rid, memberid) {
        $("#Room_" + rid + " #roomMembersDiv #m_" + memberid + " .controls .mark").css('display', 'block');
    };

    rHub.client.UserUnMarked = function (rid, memberid) {
        $("#Room_" + rid + " #roomMembersDiv #m_" + memberid + " .controls .mark").css('display', 'none');
    };

    rHub.client.ShowCamLink = function (mid, rid) {//member opened cam
        var window = chatVM.getWindow(rid, "Room");
        if (window != null) {
            var member = window.getMember(mid);
            if (member == null) {
                member = window.getQueueMember(mid);
            }
            if (member != null) {
                member.IsCamOpened(true);
                if (window.CurrentMemberSettings.NotifyOnOpenCam()) {
                    var msg = member.MemberName() + ' قد بدأ فتح الكمراء';
                    addMsgToWindow(window, msg, "joinalert");
                    //notify('info', );
                }
            }
        }
        $('#Room_' + rid + ' #roomMembersDiv #m_' + mid + ' .controls .camera').css('display', 'inline-block');
    };

    rHub.client.HideCamLink = function (mid, rid) {
        var window = chatVM.getWindow(rid, "Room");
        if (window != null) {
            var member = window.getMember(mid);
            if (member == null) {
                member = window.getQueueMember(mid);
            }
            if (member != null) {
                member.IsCamOpened(false);
                if (window.CurrentMemberSettings.NotifyOnCloseCam()) {
                    var msg = member.MemberName() + ' أغلق الكمراء';
                    addMsgToWindow(window, msg, "leftalert");
                    //notify('info', );
                }
            }
        }
        $('#Room_' + rid + ' #roomMembersDiv #m_' + mid + ' .controls .camera').css('display', 'none');
    };

    rHub.client.GiftSentInRoom = function (roomID, memberName, friendName, giftName) {
        var window = chatVM.getWindow(roomID, "Room");
        message = "<div class='pull-left giftmsg'>" + memberName + " أرسل هدية (" + giftName + ") إلى " + friendName + "</div><div style='clear:both;height:1px;'></div>";
        var history = window.MessageHistory();        
        window.MessageHistory(history + message);
        $(".MsgHistroy").slimScroll({
            railVisible: true,
            height: '400px',
            color: '#FEC401',
            railColor: '#C7C5C0',
            position: 'left',
            scrollTo: $(".MsgHistroy", "#" + window.uniqueID()).height()
        });
    };

    /*****************************************/
}

SELECT S.Status , PP.*
FROM PackagePricing pp 
inner join PackageStatusHistory SH on PP.PricingStatusID = SH.PricingStatusID
inner join PricingStatus S on SH.PricingStatusID = S.PricingStatusID


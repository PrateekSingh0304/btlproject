CREATE PROCEDURE GetAllCenterDetails
AS

Select ct.ID as CenterId,
ct.Name,
ct.Code,
CONCAT (ct.AddressLine1 , ' ' , ct.AddressLine2 ,' ' , ct.Code ,' ' , ct.Town , ' ' ,ct.Country) AS CenterDetail ,
us.ID as PersonId,
CONCAT(us.Surname ,' ', us.ForeName) as PersonName
FROM dbo.Centre ct
INNER JOIN dbo.[User] us
ON us.ID = ct.ID
INNER JOIN dbo.CountryLookup cl
ON cl.ID = ct.ID
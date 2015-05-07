USE Negocios2015
GO

ALTER TABLE Compras.productos
Add Activo BIT
go

Update Compras.productos Set Activo=1
go

Update Compras.productos Set Activo=0 Where UnidadesEnExistencia=0
go

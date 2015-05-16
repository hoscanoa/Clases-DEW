use Negocios2015
go

alter table Compras.productos
add Activo BIT
go

update Compras.productos set Activo=1
go

Update Compras.productos set Activo=0
where UnidadesEnExistencia=0
go
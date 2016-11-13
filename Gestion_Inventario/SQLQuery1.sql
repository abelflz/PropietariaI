create table User_Login(
	User_Name varchar(50) primary key,
	Password varchar(50),
);

insert into User_Login values('Abel Feliz', '20141962');
insert into User_Login values('Manuel Mariñez', 'hola');
insert into User_Login values('Ivan Serrata', 'hola');

select * from User_Login;

select costo from transaccion where idTransaccion = 1;

select costoUnitario from articulo where idArticulo = 1;

SELECT a.idArticulo as 'ID Articulo', a.descripcion_articulo as 'Nombre Articulo', 
a.costoUnitario as 'Costo Unitario', a.estado_articulo as 'Estado', ti.descripcion_inventario as 'Descripción Inventario',
ti.cuentacontable_inventario as 'Cuenta Contable', ti.estado_inventario as 'Estado Inventario' 
FROM articulo a INNER JOIN tipoinventario ti on a.idTipoInventario = ti.idTipoInventario 

select * from tipoinventario 

SELECT a.idAlmacen as 'ID Almacen', a.descripcion_almacen as 'Descripción Almacen',
a.estado_almacen as 'Estado Almacen', ti.idTipoInventario as 'ID Tipo Inventario',
axi.cantidad_AlmacenXInventario as 'Cantidad', ti.descripcion_inventario as
'Descripción Inventario', cuentacontable_inventario as 'Cuenta Contable', estado_inventario as
'Estado Inventario' FROM almacen a INNER JOIN AlmacenXInventario axi INNER JOIN tipoinventario ti
on ti.idTipoInventario = axi.idTipoInventario on axi.idAlmacen = a.idAlmacen

select * from almacen

update almacen set descripcion_almacen = 'Almacen Hogar' where idAlmacen=3

select * from tipoinventario
select * from almacen
select * from AlmacenXInventario

create table ExistenciasXInventario(
	IdAlmacen varchar(50) not null,
	IdArticulo varchar(50) not null,
	Cantidad int not null,

	Foreign key (IdAlmacen) references almacen(IdAlmacen),
	Foreign key (IdArticulo) references articulo(IdArticulo)
);

select idTipoInventario as 'ID Tipo Inventario', descripcion_inventario as 'Descripción', cuentacontable_inventario as 'Cuenta Contable', estado_inventario as 'Estado' from tipoinventario;
select * from articulo
select * from tipoinventario
select * from almacen a inner join ExistenciasXInventario ex
inner join articulo ar on ar.idArticulo = ex.IdArticulo on ex.IdAlmacen = a.idAlmacen




SELECT a.idArticulo as 'ID Articulo', a.descripcion_articulo as 'Nombre Articulo',
a.costoUnitario as 'Costo Unitario', a.estado_articulo as 'Estado', a.existencia as 'Existencia'
FROM articulo a 

update articulo set existencia = 5-3 where idArticulo = 3

select existencia from articulo 
select existencia from articulo where idArticulo = 1

select * from transaccion


select * from articulo

update articulo set existencia = 100 where idArticulo = 1

select cantidad_transaccion from transaccion
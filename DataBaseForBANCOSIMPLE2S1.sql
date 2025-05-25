create database BancoSimple2S1
go

Use BancoSimple2S1
go

Create table Clientes
(
ClienteId int primary key identity (1,1),
Nombre NVARCHAR(50) NOT NULL,
Identification NVARCHAR(20) NOT NULL
);

create table Cuentas
(
CuentaId int primary key identity (1,1),
NumeroCuenta NVARCHAR(20) NOT NULL,
Saldo decimal (18,2) not null default 0,
Activa bit not null default 1,
ClienteId int not null
foreign key (ClienteId) references Clientes(ClienteId)
);

create table Transacciones
(
TransaccionId int primary key identity (1,1),
Monto decimal (18,2) not null,
Fecha datetime not null default getdate(),
Descripcion Nvarchar(80),
CuentaOrigenId int,
CuentaDestinoId int,
foreign key (CuentaOrigenId) references Cuentas(CuentaId),
foreign key (CuentaDestinoId) references Cuentas(CuentaId)
);
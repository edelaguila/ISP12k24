-- -----------------------------------------------------
-- JIMENA
-- -----------------------------------------------------
ALTER TABLE `bd_erp`.`tbl_existencias` 
ADD INDEX `tbl_producto_id_producto_idx` (`tbl_producto_id_producto`);
;
ALTER TABLE `bd_erp`.`tbl_existencias` 
ADD CONSTRAINT `tbl_producto_id_producto`
  FOREIGN KEY (`tbl_producto_id_producto`)
  REFERENCES `bd_erp`.`tbl_producto` (`cod_producto`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;
  
 -- -----------------------------------------------------
-- DAVID Y OTTO
-- ----------------------------------------------------- 
ALTER TABLE `bd_erp`.`tbl_ventaspedido` 
DROP FOREIGN KEY `fk_tbl_Ventas_pedido_tbl_Producto1`;
ALTER TABLE `bd_erp`.`tbl_ventaspedido` 
DROP COLUMN `tbl_Producto_id_producto`,
DROP COLUMN `fecha_vencimiento_ventas_ped`,
DROP COLUMN `nombre_solicitante_ventas_ped`,
DROP INDEX `fk_tbl_Ventas_pedido_tbl_Producto1_idx` ;


ALTER TABLE `bd_erp`.`tbl_ventaspedido` 
ADD COLUMN `tbl_detalle_cotizacion_id` INT NOT NULL AFTER `id_vendedor`,
ADD INDEX `tbl_detalle_cotizacion_id_idx` (`tbl_detalle_cotizacion_id`) ;


ALTER TABLE `bd_erp`.`tbl_ventaspedido` 
ADD CONSTRAINT `tbl_detalle_cotizacion_id`
  FOREIGN KEY (`tbl_detalle_cotizacion_id`)
  REFERENCES `bd_erp`.`tbl_detalle_cotizacion` (`id_detalle_cotizacion`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;


ALTER TABLE `bd_erp`.`tbl_detalleventas` 
DROP COLUMN `precio_selec_det`,
DROP COLUMN `seleccion_prod_det`;

ALTER TABLE `bd_erp`.`tbl_facturaxcobrar` 
DROP COLUMN `cant_prod_solicitado_facxpag`,
DROP COLUMN `nom_Prod_Solicitado_facxpag`,
CHANGE COLUMN `total_facxcob` `total_facxcob` DOUBLE NOT NULL ,
CHANGE COLUMN `tiempoPago_facxcob` `tiempoPago_facxcob` VARCHAR(45) NOT NULL ;

ALTER TABLE `bd_erp`.`tbl_ventaspedido` 
ADD INDEX `fk_id_vendedor_idx` (`id_vendedor`) ;
;



ALTER TABLE `bd_erp`.`tbl_ventaspedido` 
ADD CONSTRAINT `fk_id_vendedor`
  FOREIGN KEY (`id_vendedor`)
  REFERENCES `bd_erp`.`tbl_vendedor` (`id_vendedor`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

-- -----------------------------------------------------
-- DIEGO
-- -----------------------------------------------------
use bd_erp;
create table tbl_mantenimientos_agregar_bancos(
pk_manag_id_ban int auto_increment primary key,
manag_id_bancoag int, 
manag_nombre_banco varchar(100) unique,
manag_status int
);
create table tbl_conciliacion_bancaria(
	pk_conb_id_conciliacion int auto_increment primary key,
    conb_anio_conciliacion varchar(100),
    conb_mes_conciliacion varchar(100),
    fk_conb_mov_libro float NOT NULL,
    fk_conb_estatusConc int NOT NULL, 
    conb_mov_conciliacion float,
    conb_saldo_final float,
    conb_status int
);

create table tbl_monedaBanco(
pk_mon_id_moneda int auto_increment primary key,
mon_nomMoneda varchar(100) unique,
mon_status int

);
insert into `tbl_monedaBanco`( `pk_mon_id_moneda`, `mon_nomMoneda`) values 
(1, "Quetzales"),
(2, "Dólares");

create table tbl_mantenimientos_agregar_cuenta (
pk_manac_id_cuenta int auto_increment primary key,
manac_numero_de_cuenta int unique, 
fk_manac_tipo_de_moneda varchar(100),
manac_tipo_de_cuenta varchar(100),
fk_manac_selec_banco varchar(50),
manac_alias varchar(100), 
manac_status int,
foreign key(fk_manac_selec_banco) references tbl_mantenimientos_agregar_bancos(manag_nombre_banco), 
foreign key (fk_manac_tipo_de_moneda) references tbl_monedaBanco(mon_nomMoneda)
); 

create table tbl_mantenimientos_tipo_movimiento(
pk_movtm_id_transaccion int auto_increment primary key,
movtm_transacciones_existentes varchar(100) unique,
movtm_status int,
movtm_valor_transaccion int NOT NULL
);

-- CREAR OTRA TABLA PARA LOS TIPOS DE MOVIMIENTOS EXISTENTES QUE SOLO LOS ALMACENE

CREATE TABLE tbl_movimientosBancarios(
pk_movban_id_transaccion int auto_increment primary key,
movban_valor_transaccion float NOT NULL,
movban_descripcion_transaccion varchar(100),
fk_movban_num_cuenta int,
fk_movban_tipo_transaccion varchar(50),
fk_movban_valorTrans int NOT NULL,
movban_status int,
movban_fecha_de_ingreso datetime,
manag_status_conciliacion int NOT NULL,
foreign key(fk_movban_num_cuenta) references tbl_mantenimientos_agregar_cuenta(manac_numero_de_cuenta),
foreign key(fk_movban_tipo_transaccion) references tbl_mantenimientos_tipo_movimiento(movtm_transacciones_existentes)
);

create table tbl_registro_moneda(
regmon_id_Moneda int auto_increment primary key,
regmon_Tipo_moneda varchar(100) unique,
regmon_Valor_moneda float, 
regmon_fecha_de_registro DATETIME,
regmon_status int

);


create table tbl_moneda(
mon_id_moneda int auto_increment primary key,
fk_mon_nombre_moneda varchar(50),	
mon_Cant_moneda float,
mon_status int,
foreign key (fk_mon_nombre_moneda) references tbl_registro_moneda(regmon_Tipo_moneda)
);

create table tbl_Banco2(
ban_id_Banco int auto_increment primary key,
fk_ban_Nombre_banco varchar(100),
ban_status int,
foreign key (fk_ban_Nombre_banco) references tbl_mantenimientos_agregar_bancos(manag_nombre_banco)
);
-- SE INSERTAN ESTOS DATOS POR CUESTIONES DE FUNCIONALIDAD DE MOVIMIENTOS BANCARIOS
insert into tbl_mantenimientos_agregar_bancos (pk_manag_id_ban, manag_id_bancoag, manag_nombre_banco, manag_status) values 
 (1, 111, 'Banco industrial', 1),
 (2, 222, 'Banrural', 1);
 
insert into tbl_mantenimientos_tipo_movimiento(pk_movtm_id_transaccion, movtm_transacciones_existentes,  movtm_status, movtm_valor_transaccion) values 
(1, 'Debito',  1, 0),
(2, 'Credito', 1, 1);


insert into tbl_mantenimientos_agregar_cuenta (pk_manac_id_cuenta, manac_numero_de_cuenta, fk_manac_tipo_de_moneda, manac_tipo_de_cuenta, fk_manac_selec_banco, manac_alias, manac_status) values 
(1, 10001, 'Quetzales', 'Ahorro', 'Banco industrial', '<Diego Marroquin', 1),
(2, 10002, 'Dólares', 'Monetaria', 'Banrural', 'Diego Marroquin', 1);
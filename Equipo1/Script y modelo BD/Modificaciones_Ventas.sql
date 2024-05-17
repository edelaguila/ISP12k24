CREATE VIEW vista_cotizaciones AS
SELECT No_Cotizacion AS NoCotizacion, fecha_coti AS FechaCotizacion, fechaFinal_coti AS ValidaHasta, Solicitud AS Estado
FROM tbl_cotizaciones;


create table tbl_pagoFact(
    id_pagoFact INT AUTO_INCREMENT PRIMARY KEY,
    noFactura VARCHAR(255) NOT NULL,
    cliente INT NOT NULL,
    banco VARCHAR(100) NOT NULL,
    concepto VARCHAR(10) NOT NULL,
    monto_pago double NOT NULL,
	extra_pago double NOT NULL,
	fecha_pago DATE NOT NULL
);

ALTER TABLE `bd_erp`.`tbl_pagofact` 
ADD INDEX `idcliente_idx` (`cliente` ASC) VISIBLE;
;
ALTER TABLE `bd_erp`.`tbl_pagofact` 
ADD CONSTRAINT `idcliente`
  FOREIGN KEY (`cliente`)
  REFERENCES `bd_erp`.`tbl_clientes` (`id_cliente`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

ALTER TABLE `bd_erp`.`tbl_pagofact` 
ADD COLUMN `NIT` VARCHAR(45) NOT NULL AFTER `fecha_pago`;

ALTER TABLE `bd_erp`.`tbl_facturaxcobrar` 
ADD COLUMN `fecha_factura` VARCHAR(45) NOT NULL AFTER `tbl_Clientes_id_cliente`;
ALTER TABLE `bd_erp`.`tbl_pagofact` 

CHANGE COLUMN `concepto` `concepto` VARCHAR(100) NOT NULL ,
CHANGE COLUMN `fecha_pago` `fecha_pago` VARCHAR(45) NOT NULL ;

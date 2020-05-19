CREATE DATABASE IF NOT EXISTS produccion;
USE produccion;

CREATE TABLE `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` text COLLATE utf8_unicode_ci NOT NULL,
  `indice` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ayuda`
--

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`) VALUES
(1, 'Página web ayuda/ayuda.chm', 'menu.html'),
(2, 'Página web ayuda/ayuda.chm', 'Menúboletos.html');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cif`
--

CREATE TABLE `cif` (
  `idc` int(11) NOT NULL,
  `nombre_cuenta` varchar(50) NOT NULL,
  `cantidad` double NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cif`
--

INSERT INTO `cif` (`idc`, `nombre_cuenta`, `cantidad`, `estado`) VALUES
(1, 'costos indirectos de fabricacion', 800, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `configuraciones_inventarios`
--

CREATE TABLE `configuraciones_inventarios` (
  `cod_config` int(11) NOT NULL,
  `temporada` varchar(11) NOT NULL,
  `maximo` int(11) NOT NULL,
  `repedido` int(11) NOT NULL,
  `minimo` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `configuraciones_inventarios`
--

INSERT INTO `configuraciones_inventarios` (`cod_config`, `temporada`, `maximo`, `repedido`, `minimo`, `estado`) VALUES
(1, 'verano', 400, 200, 100, 1),
(2, 'invierno', 80, 50, 20, 1),
(4, 'primavera', 900, 500, 350, 1),
(5, 'otoño', 600, 500, 200, 1),
(6, 'Fin de año', 800, 500, 400, 1),
(7, 'Inicio de a', 4000, 1000, 500, 1),
(8, 'Baja', 1500, 500, 200, 1),
(9, 'Demanda', 2000, 1000, 800, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `costos_produccion`
--

CREATE TABLE `costos_produccion` (
  `id_costos` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `suma_costo_mp` double DEFAULT NULL,
  `suma_costo_mo` double DEFAULT NULL,
  `cif_unidad` double DEFAULT NULL,
  `costo_unitario_producto` double DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalles_recetas`
--

CREATE TABLE `detalles_recetas` (
  `id_detalle` int(11) NOT NULL,
  `id_proceso` int(5) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` double NOT NULL,
  `rendimiento_restante` double NOT NULL,
  `rendimiento_fijo` double NOT NULL,
  `cantidad_rendimiento_f` double NOT NULL,
  `costo_unitario` double NOT NULL,
  `unidad_medida` varchar(9) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `detalles_recetas`
--

INSERT INTO `detalles_recetas` (`id_detalle`, `id_proceso`, `id_producto`, `cantidad`, `rendimiento_restante`, `rendimiento_fijo`, `cantidad_rendimiento_f`, `costo_unitario`, `unidad_medida`, `estado`) VALUES
(1, 1, 10, 10.5, 0, 0, 0, 0, 'gr', 0),
(2, 1, 2, 1.5, 98.8125, 5, 40, 50, 'ml', 1),
(3, 1, 8, 1.5, 0, 0, 0, 0, 'ml', 0),
(4, 1, 8, 4.5, 0, 0, 0, 0, 'ml', 0),
(5, 4, 8, 1, 0, 0, 0, 0, 'ml', 0),
(6, 4, 8, 3.5, 0, 0, 0, 0, 'ml', 0),
(7, 4, 2, 1.1, 0, 0, 0, 0, 'ml', 0),
(8, 1, 4, 10, 53.775, 15, 200, 23.3333333333333, 'ml', 1),
(9, 1, 5, 1, 165, 20, 100, 20, 'ml', 1),
(10, 1, 9, 10.22, 39.984, 60, 200, 5.83333333333333, 'ml', 1),
(12, 4, 4, 1, 0, 0, 0, 0, 'ml', 0),
(13, 4, 8, 2, 69.2, 20, 200, 7.5, 'ml', 1),
(14, 4, 4, 1, 430, 50, 100, 7, 'ml', 1),
(15, 4, 2, 2, 125, 50, 200, 5, 'ml', 1),
(16, 2, 3, 2.5, 197.5, 25, 100, 8, 'ml', 1),
(17, 2, 4, 5, 53.6, 10, 100, 35, 'ml', 1),
(18, 5, 2, 40, 12.4625, 2.5, 100, 100, 'ml', 1),
(19, 6, 15, 6, 180, 20, 100, 1.25, 'ml', 0),
(20, 6, 15, 15, 90, 10, 100, 2.5, 'ml', 1),
(21, 7, 17, 2, 450, 50, 100, 0.4, 'ml', 1),
(22, 7, 18, 1, 1800, 20, 10, 1.25, 'ml', 1),
(23, 7, 19, 2, 3600, 40, 10, 0.75, 'ml', 1),
(24, 8, 21, 42, 180, 20, 100, 5, 'oz', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `id_empleado` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `sexo` varchar(10) DEFAULT NULL,
  `fecha_de_nacimiento` date DEFAULT NULL,
  `cui` varchar(20) DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `id_puesto` int(11) DEFAULT NULL,
  `id_area` int(11) DEFAULT NULL,
  `nit` varchar(13) DEFAULT NULL,
  `direccion` varchar(50) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`id_empleado`, `nombre`, `apellido`, `sexo`, `fecha_de_nacimiento`, `cui`, `correo`, `id_puesto`, `id_area`, `nit`, `direccion`, `estado`) VALUES
(1, 'Juan Jose', 'Gamez Blanco', 'Masculino', '1997-11-23', '555465466', 'juan@hotmail.com', 1, 1, '6161654-4', 'BDM', 1),
(2, 'Edgar ruben', 'Baches', 'Masculinos', '1997-04-14', '4586153176', 'juan@hotmail.com', 3, 2, '6161654-3', 'zona 21', 1),
(3, 'josue', 'Rodas', 'Masculino', '2020-04-21', '23423423', 'juan@hotmail.com', 1, 3, '6161654-4', 'Solola', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventarios_produccion`
--

CREATE TABLE `inventarios_produccion` (
  `id_inventario` int(5) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cod_config` int(11) NOT NULL,
  `cantidad_total` double NOT NULL,
  `unidad_medida` varchar(40) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `inventarios_produccion`
--

INSERT INTO `inventarios_produccion` (`id_inventario`, `id_producto`, `cod_config`, `cantidad_total`, `unidad_medida`, `estado`) VALUES
(1, 2, 6, 800, 'ml', 0),
(2, 2, 4, 800, 'ml', 0),
(3, 4, 2, 810, 'ml', 0),
(4, 5, 2, 825, 'ml', 0),
(5, 7, 5, 900, 'ml', 0),
(6, 3, 4, 1205, 'ml', 0),
(7, 9, 4, 133.28, 'ml', 0),
(8, 10, 4, 800, 'gr', 1),
(9, 8, 1, 692, 'ml', 0),
(10, 7, 4, 900, 'ml', 0),
(11, 7, 1, 400, 'ml', 0),
(12, 7, 5, 800, 'ml', 0),
(13, 9, 2, 133.28, 'ml', 0),
(14, 2, 4, 800, 'ml', 0),
(15, 8, 4, 692, 'ml', 1),
(16, 4, 4, 810, 'ml', 0),
(17, 9, 4, 900, 'ml', 0),
(18, 5, 4, 825, 'ml', 1),
(19, 9, 4, 800, 'gr', 1),
(20, 2, 4, 800, 'ml', 0),
(21, 4, 4, 810, 'ml', 0),
(22, 3, 4, 900, 'gr', 1),
(23, 2, 4, 800, 'ml', 1),
(24, 4, 4, 810, 'ml', 1),
(25, 12, 4, 900, 'kg', 1),
(26, 15, 4, 900, 'kg', 1),
(27, 17, 4, 820, '1-kg', 0),
(28, 18, 4, 860, '1-kg', 0),
(29, 19, 4, 820, '1-kg', 0),
(30, 21, 4, 873.75, 'lb', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimientos_inventario_detalle`
--

CREATE TABLE `movimientos_inventario_detalle` (
  `id_movimiento_inventario_detalle` int(11) NOT NULL,
  `id_movimiento_inventario_encabezado` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad_movimiento` int(11) DEFAULT NULL,
  `costo_producto` double DEFAULT NULL,
  `precio_producto` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimientos_inventario_encabezado`
--

CREATE TABLE `movimientos_inventario_encabezado` (
  `id_movimiento_inventario_encabezado` int(11) NOT NULL,
  `id_tipo_movimiento` int(11) NOT NULL,
  `nombre_movimiento` varchar(45) DEFAULT NULL,
  `descripcion_movimiento` text DEFAULT NULL,
  `fecha_movimiento` date DEFAULT NULL,
  `bodaga_salida` int(11) DEFAULT NULL,
  `bodega_entrada` int(11) DEFAULT NULL,
  `id_orden_transporte_encabezado` int(11) DEFAULT NULL,
  `ESTADO` tinyint(4) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ordenes_pendientes`
--

CREATE TABLE `ordenes_pendientes` (
  `cod_opp` int(11) NOT NULL,
  `cod_orden` int(11) NOT NULL,
  `fecha_limite` date NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Disparadores `ordenes_pendientes`
--
DELIMITER $$
CREATE TRIGGER `producto_en_proceso` AFTER UPDATE ON `ordenes_pendientes` FOR EACH ROW INSERT INTO productos_proceso (cod_orden, fecha_inicio) VALUES (new.cod_orden, NOW())
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccion_detalles`
--

CREATE TABLE `produccion_detalles` (
  `id_detalle` int(3) NOT NULL,
  `cod_orden` int(11) NOT NULL,
  `id_producto` int(11) DEFAULT NULL,
  `cantidad_producto` int(8) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccion_encabezados`
--

CREATE TABLE `produccion_encabezados` (
  `cod_orden` int(11) NOT NULL,
  `fecha_orden` date DEFAULT NULL,
  `fecha_limite` date NOT NULL,
  `tipo_produccion` varchar(50) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Disparadores `produccion_encabezados`
--
DELIMITER $$
CREATE TRIGGER `ordenes_pen` AFTER INSERT ON `produccion_encabezados` FOR EACH ROW INSERT INTO ordenes_pendientes (cod_orden,fecha_limite) VALUES (new.cod_orden,new.fecha_limite)
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccion_procesos`
--

CREATE TABLE `produccion_procesos` (
  `id_proceso` int(5) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion_proceso` varchar(1000) NOT NULL,
  `tiempo_pp` float NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `produccion_procesos`
--

INSERT INTO `produccion_procesos` (`id_proceso`, `id_producto`, `nombre`, `descripcion_proceso`, `tiempo_pp`, `estado`) VALUES
(1, 6, 'Para Camaronina', 'ALIMENTO COMPLETO CON 35% DE PROTEINA REFORZADO\r\n\r\nVITAMINAS C Y E 25ml y15 ml Respectivamente \r\nSELENIO ORGANICO 25 gr\r\nFUCOIDANES 15gr\r\nNUCLEOTIDES 15mgr\r\nBETA 1-3 1-6 GLUCANOS 25ml ', 13, 1),
(2, 11, 'Para TetraColor Tropical Flakes', 'Harina de pescado 15gr \r\nLevadura deshidratada 15gr\r\nHarina de camarón 20oz\r\nArroz moreno 20oz\r\nGluten de trigo\r\nAvena 10gr\r\nAcido ascórbico (fuente de vit.C),\r\nFosfato (fuente de vit. B2)\r\nA-tocoferol-acetato (fuente de vit. E)\r\nD-pantotenato de calcio \r\nMononitrato de tiamina (fuente de vit. B1) \r\nHidrocloruro de piridoxina (fuente de vit. B6)\r\nPalmitato (fuente de vit. A) \r\nSulfato de manganeso monohidratado, sulfato de zinc monohidratado, sulfato de hierro monohidratado', 0.8, 1),
(3, 1, 'Para Concentrado Dog Show', 'Alimento concentrado para perro \r\n\r\n', 12.5, 0),
(4, 1, 'para Dod Show', 'Concentrado', 0.5, 1),
(5, 13, 'Frijol', 'Bolsa de 40 kg de frijol rojo ', 5, 1),
(6, 14, 'Maiz porva', 'Cada bolsa debe tener 20 kg de semillas', 8, 1),
(7, 16, 'Hamburguesa', '2 rodajas de pan\r\n1 kg carne\r\n2g lechuga', 3, 0),
(8, 20, 'ejemplo', 'ejemplo', 5, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id_producto` int(11) NOT NULL,
  `id_tipo_producto` int(11) NOT NULL,
  `nombre_producto` varchar(45) DEFAULT NULL,
  `Descripcion` varchar(800) NOT NULL,
  `costo_producto` double DEFAULT NULL,
  `precio_producto` double DEFAULT NULL,
  `stock_producto` int(11) NOT NULL,
  `cantidad_maxima_producto` int(11) NOT NULL,
  `cantidad_minima_producto` int(11) NOT NULL,
  `ESTADO` tinyint(4) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id_producto`, `id_tipo_producto`, `nombre_producto`, `Descripcion`, `costo_producto`, `precio_producto`, `stock_producto`, `cantidad_maxima_producto`, `cantidad_minima_producto`, `ESTADO`) VALUES
(1, 1, 'Dog Show', 'concentrado para perro', 120, 150, 500, 500, 100, 1),
(2, 2, 'Bolsa Vitamina C 900g', 'Vitamina para el sistema inmunologico del animal', 0, 250, 500, 500, 100, 1),
(3, 2, 'SELENIO ORGANICO', 'Selisseo® 2% Se es una fuente orgánica de selenio que contiene seleno-metionina hidróxi-análoga diluida en un vehículo a base de sílice, para utilizarse en todas las especies y que aporta el 100% de selenio.', 0, 200, 500, 0, 0, 1),
(4, 2, 'Beta Glucano', 'son polisacáridos que sólo contienen glucosa como componentes estructurales', 0, 350, 500, 0, 0, 1),
(5, 2, 'Fucoidan', 'sustancia viscosa proveniente de las algas marinas', 0, 400, 500, 0, 0, 1),
(6, 1, 'Camaronina', 'Producto para alimentar camarones, langostas de agua dulce', 120, 180, 400, 500, 300, 1),
(7, 2, 'Nucleotido', 'Los nucleótidos son moléculas orgánicas formadas por la unión covalente de un monosacárido de cinco carbonos', 0, 120, 500, 0, 0, 1),
(8, 2, 'Bolsa Vitamina E 900 g', 'Vitamina E para salud de camarones y crustaceos', 0, 150, 500, 0, 0, 1),
(9, 2, 'Levadura Deshidratada', 'Levadura ', 0, 350, 500, 0, 0, 1),
(10, 2, 'Arroz Moreno', 'Arroz para produccion de tetra color', 0, 185, 500, 0, 0, 1),
(11, 1, 'TetraColor Tropical Flakes', 'Comida de Pez', 130, 200, 600, 800, 500, 1),
(12, 2, 'Frijol Regional', 'Frijol Rojo Semilla', 0, 150, 1500, 1500, 500, 1),
(13, 1, 'Borlsa de frijol rojo regional', 'bolsa de 40 kg', 120, 130, 800, 800, 300, 1),
(14, 1, 'Bolsa de maiz porva', 'bolsa de maiz porva para la venta', 0, 120, 500, 500, 100, 1),
(15, 2, 'Semilla maiz porva', 'semilla de maiz', 0, 25, 500, 500, 100, 1),
(16, 1, 'Menu numero 1 Big mac', 'Hamburguesa para la venta', 120, 130, 500, 500, 200, 0),
(17, 2, 'Pan', 'Pan', 0, 20, 500, 500, 200, 0),
(18, 2, 'lechuga', 'lechuga', 0, 25, 500, 500, 200, 0),
(19, 2, 'carne', 'carne', 0, 30, 500, 500, 200, 0),
(20, 1, 'ejemplo', 'ejemplo', 120, 120, 500, 500, 100, 1),
(21, 2, 'ejemplo2', 'ejemplo2', 0, 100, 500, 500, 100, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos_proceso`
--

CREATE TABLE `productos_proceso` (
  `id_prodproc` int(11) NOT NULL,
  `cod_orden` int(11) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Disparadores `productos_proceso`
--
DELIMITER $$
CREATE TRIGGER `orden_terminada` AFTER UPDATE ON `productos_proceso` FOR EACH ROW INSERT INTO productos_terminados ( cod_orden) VALUES (new.cod_orden)
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos_terminados`
--

CREATE TABLE `productos_terminados` (
  `id_producto_term` int(11) NOT NULL,
  `cod_orden` int(11) DEFAULT NULL,
  `costo_total` float NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puestos`
--

CREATE TABLE `puestos` (
  `id_puesto` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `id_sueldo` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `puestos`
--

INSERT INTO `puestos` (`id_puesto`, `nombre`, `id_sueldo`, `estado`) VALUES
(1, 'Desarollador', 3, 1),
(2, 'Secretaria', 3, 1),
(3, 'Gerente', 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `recetas_produccion`
--

CREATE TABLE `recetas_produccion` (
  `id_receta_p` int(11) NOT NULL,
  `id_detalle_receta` int(5) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro_horas_emp`
--

CREATE TABLE `registro_horas_emp` (
  `cod_registro` int(11) NOT NULL,
  `cod_orden` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `hora_entrada` time NOT NULL,
  `hora_salida_aa` time NOT NULL,
  `hora_entrada_da` time NOT NULL,
  `hora_salida_da` time NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `solicitudes_detalles`
--

CREATE TABLE `solicitudes_detalles` (
  `id_detalle` int(11) NOT NULL,
  `cod_solicitud` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` double NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Disparadores `solicitudes_detalles`
--
DELIMITER $$
CREATE TRIGGER `suministro` AFTER INSERT ON `solicitudes_detalles` FOR EACH ROW BEGIN
UPDATE inventarios_produccion SET cantidad_total = cantidad_total + new.cantidad WHERE id_producto = new.id_producto;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `solicitudes_encabezados`
--

CREATE TABLE `solicitudes_encabezados` (
  `cod_solicitud` int(11) NOT NULL,
  `fecha_solicitud` date NOT NULL,
  `prioridad` varchar(10) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sueldos`
--

CREATE TABLE `sueldos` (
  `id_sueldo` int(11) NOT NULL,
  `salario` float DEFAULT NULL,
  `estado` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `sueldos`
--

INSERT INTO `sueldos` (`id_sueldo`, `salario`, `estado`) VALUES
(1, 6000, 1),
(2, 5000, 1),
(3, 3000, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `unidades_medida`
--

CREATE TABLE `unidades_medida` (
  `id_medida` int(11) NOT NULL,
  `unidad1` varchar(20) NOT NULL,
  `cantidad1` double NOT NULL,
  `unidad2` varchar(11) NOT NULL,
  `cantidad2` double NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `unidades_medida`
--

INSERT INTO `unidades_medida` (`id_medida`, `unidad1`, `cantidad1`, `unidad2`, `cantidad2`, `estado`) VALUES
(20, 'lb', 1, 'oz', 16, 1),
(21, 'oz', 1, 'lb', 0.0625, 1),
(22, 'lb', 1, 'lb', 1, 1),
(23, 'oz', 1, 'oz', 1, 1),
(24, 'kg', 1, 'gr', 1000, 1),
(25, 'gr', 1, 'kg', 0.001, 1),
(26, 'kg', 1, 'kg', 1, 1),
(27, 'gr', 1, 'gr', 1, 1),
(28, 'lt', 1, 'ml', 1000, 1),
(29, 'ml', 1, 'lt', 0.001, 1),
(30, 'lt', 1, 'lt', 1, 1),
(31, 'ml', 1, 'ml', 1, 1),
(32, 'lt', 1, 'gal', 0.2641, 1),
(33, 'gal', 1, 'lt', 3.78644452858766, 1),
(34, 'gal', 1, 'gal', 1, 1),
(35, 'taza', 1, 'lt', 0.24, 1),
(36, 'lt', 1, 'taza', 4.16666666666667, 1),
(37, 'taza', 1, 'taza', 1, 1),
(38, 'ton', 1, 'lb', 2204.62, 1),
(39, 'lb', 1, 'ton', 0.00045359290943564, 1),
(40, 'ton', 1, 'ton', 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cif`
--
ALTER TABLE `cif`
  ADD PRIMARY KEY (`idc`);

--
-- Indices de la tabla `configuraciones_inventarios`
--
ALTER TABLE `configuraciones_inventarios`
  ADD PRIMARY KEY (`cod_config`);

--
-- Indices de la tabla `costos_produccion`
--
ALTER TABLE `costos_produccion`
  ADD PRIMARY KEY (`id_costos`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `detalles_recetas`
--
ALTER TABLE `detalles_recetas`
  ADD PRIMARY KEY (`id_detalle`,`id_proceso`) USING BTREE,
  ADD KEY `detalles_recetas_ibfk_12` (`id_proceso`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`id_empleado`),
  ADD KEY `id_puesto` (`id_puesto`);

--
-- Indices de la tabla `inventarios_produccion`
--
ALTER TABLE `inventarios_produccion`
  ADD PRIMARY KEY (`id_inventario`),
  ADD KEY `fk_producto` (`id_producto`),
  ADD KEY `fk_configuraciones` (`cod_config`);

--
-- Indices de la tabla `movimientos_inventario_detalle`
--
ALTER TABLE `movimientos_inventario_detalle`
  ADD PRIMARY KEY (`id_movimiento_inventario_detalle`,`id_movimiento_inventario_encabezado`);

--
-- Indices de la tabla `movimientos_inventario_encabezado`
--
ALTER TABLE `movimientos_inventario_encabezado`
  ADD PRIMARY KEY (`id_movimiento_inventario_encabezado`);

--
-- Indices de la tabla `ordenes_pendientes`
--
ALTER TABLE `ordenes_pendientes`
  ADD PRIMARY KEY (`cod_opp`),
  ADD KEY `fk_pendientes` (`cod_orden`);

--
-- Indices de la tabla `produccion_detalles`
--
ALTER TABLE `produccion_detalles`
  ADD PRIMARY KEY (`id_detalle`,`cod_orden`) USING BTREE,
  ADD KEY `fk_producto2` (`id_producto`),
  ADD KEY `cod_orden` (`cod_orden`);

--
-- Indices de la tabla `produccion_encabezados`
--
ALTER TABLE `produccion_encabezados`
  ADD PRIMARY KEY (`cod_orden`);

--
-- Indices de la tabla `produccion_procesos`
--
ALTER TABLE `produccion_procesos`
  ADD PRIMARY KEY (`id_proceso`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id_producto`);

--
-- Indices de la tabla `productos_proceso`
--
ALTER TABLE `productos_proceso`
  ADD PRIMARY KEY (`id_prodproc`),
  ADD KEY `cod_orden` (`cod_orden`);

--
-- Indices de la tabla `productos_terminados`
--
ALTER TABLE `productos_terminados`
  ADD PRIMARY KEY (`id_producto_term`);

--
-- Indices de la tabla `puestos`
--
ALTER TABLE `puestos`
  ADD PRIMARY KEY (`id_puesto`),
  ADD KEY `id_sueldo` (`id_sueldo`);

--
-- Indices de la tabla `registro_horas_emp`
--
ALTER TABLE `registro_horas_emp`
  ADD PRIMARY KEY (`cod_registro`),
  ADD KEY `id_empleado` (`id_empleado`),
  ADD KEY `cod_orden` (`cod_orden`);

--
-- Indices de la tabla `solicitudes_detalles`
--
ALTER TABLE `solicitudes_detalles`
  ADD PRIMARY KEY (`id_detalle`,`cod_solicitud`) USING BTREE,
  ADD KEY `cod_solicitud` (`cod_solicitud`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `solicitudes_encabezados`
--
ALTER TABLE `solicitudes_encabezados`
  ADD PRIMARY KEY (`cod_solicitud`);

--
-- Indices de la tabla `sueldos`
--
ALTER TABLE `sueldos`
  ADD PRIMARY KEY (`id_sueldo`);

--
-- Indices de la tabla `unidades_medida`
--
ALTER TABLE `unidades_medida`
  ADD PRIMARY KEY (`id_medida`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cif`
--
ALTER TABLE `cif`
  MODIFY `idc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `configuraciones_inventarios`
--
ALTER TABLE `configuraciones_inventarios`
  MODIFY `cod_config` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `costos_produccion`
--
ALTER TABLE `costos_produccion`
  MODIFY `id_costos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalles_recetas`
--
ALTER TABLE `detalles_recetas`
  MODIFY `id_detalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `inventarios_produccion`
--
ALTER TABLE `inventarios_produccion`
  MODIFY `id_inventario` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT de la tabla `movimientos_inventario_detalle`
--
ALTER TABLE `movimientos_inventario_detalle`
  MODIFY `id_movimiento_inventario_detalle` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `movimientos_inventario_encabezado`
--
ALTER TABLE `movimientos_inventario_encabezado`
  MODIFY `id_movimiento_inventario_encabezado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `ordenes_pendientes`
--
ALTER TABLE `ordenes_pendientes`
  MODIFY `cod_opp` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `produccion_detalles`
--
ALTER TABLE `produccion_detalles`
  MODIFY `id_detalle` int(3) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `produccion_encabezados`
--
ALTER TABLE `produccion_encabezados`
  MODIFY `cod_orden` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `produccion_procesos`
--
ALTER TABLE `produccion_procesos`
  MODIFY `id_proceso` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT de la tabla `productos_proceso`
--
ALTER TABLE `productos_proceso`
  MODIFY `id_prodproc` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `productos_terminados`
--
ALTER TABLE `productos_terminados`
  MODIFY `id_producto_term` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `puestos`
--
ALTER TABLE `puestos`
  MODIFY `id_puesto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `registro_horas_emp`
--
ALTER TABLE `registro_horas_emp`
  MODIFY `cod_registro` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `solicitudes_detalles`
--
ALTER TABLE `solicitudes_detalles`
  MODIFY `id_detalle` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `solicitudes_encabezados`
--
ALTER TABLE `solicitudes_encabezados`
  MODIFY `cod_solicitud` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `sueldos`
--
ALTER TABLE `sueldos`
  MODIFY `id_sueldo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `unidades_medida`
--
ALTER TABLE `unidades_medida`
  MODIFY `id_medida` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `costos_produccion`
--
ALTER TABLE `costos_produccion`
  ADD CONSTRAINT `costos_produccion_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalles_recetas`
--
ALTER TABLE `detalles_recetas`
  ADD CONSTRAINT `detalles_recetas_ibfk_12` FOREIGN KEY (`id_proceso`) REFERENCES `produccion_procesos` (`id_proceso`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `detalles_recetas_ibfk_13` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `empleados_ibfk_1` FOREIGN KEY (`id_puesto`) REFERENCES `puestos` (`id_puesto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `inventarios_produccion`
--
ALTER TABLE `inventarios_produccion`
  ADD CONSTRAINT `fk_configuraciones` FOREIGN KEY (`cod_config`) REFERENCES `configuraciones_inventarios` (`cod_config`),
  ADD CONSTRAINT `fk_producto` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`);

--
-- Filtros para la tabla `ordenes_pendientes`
--
ALTER TABLE `ordenes_pendientes`
  ADD CONSTRAINT `fk_pendientes` FOREIGN KEY (`cod_orden`) REFERENCES `produccion_encabezados` (`cod_orden`);

--
-- Filtros para la tabla `produccion_detalles`
--
ALTER TABLE `produccion_detalles`
  ADD CONSTRAINT `fk_producto2` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `produccion_detalles_ibfk_1` FOREIGN KEY (`cod_orden`) REFERENCES `produccion_encabezados` (`cod_orden`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `produccion_procesos`
--
ALTER TABLE `produccion_procesos`
  ADD CONSTRAINT `produccion_procesos_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `productos_proceso`
--
ALTER TABLE `productos_proceso`
  ADD CONSTRAINT `productos_proceso_ibfk_1` FOREIGN KEY (`cod_orden`) REFERENCES `produccion_encabezados` (`cod_orden`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `puestos`
--
ALTER TABLE `puestos`
  ADD CONSTRAINT `puestos_ibfk_1` FOREIGN KEY (`id_sueldo`) REFERENCES `sueldos` (`id_sueldo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `registro_horas_emp`
--
ALTER TABLE `registro_horas_emp`
  ADD CONSTRAINT `registro_horas_emp_ibfk_2` FOREIGN KEY (`id_empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `registro_horas_emp_ibfk_3` FOREIGN KEY (`cod_orden`) REFERENCES `produccion_encabezados` (`cod_orden`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `solicitudes_detalles`
--
ALTER TABLE `solicitudes_detalles`
  ADD CONSTRAINT `solicitudes_detalles_ibfk_1` FOREIGN KEY (`cod_solicitud`) REFERENCES `solicitudes_encabezados` (`cod_solicitud`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `solicitudes_detalles_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `productos` (`id_producto`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;



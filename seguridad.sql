-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-05-2020 a las 05:56:41
-- Versión del servidor: 10.4.8-MariaDB
-- Versión de PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `seguridad`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `procedimientoLogin` (IN `usuario` VARCHAR(25), IN `clave` VARCHAR(25))  NO SQL
Select tbl_usuario.PK_id_Usuario FROM tbl_usuario where tbl_usuario.PK_id_Usuario = usuario and tbl_usuario.password_usuario = MD5(clave) AND tbl_usuario.estado_usuario=1$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicacion`
--

CREATE TABLE `tbl_aplicacion` (
  `PK_id_aplicacion` int(11) NOT NULL,
  `PK_id_modulo` int(11) NOT NULL,
  `nombre_aplicacion` varchar(45) DEFAULT NULL,
  `descripcion_aplicacion` varchar(200) DEFAULT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_aplicacion`
--

INSERT INTO `tbl_aplicacion` (`PK_id_aplicacion`, `PK_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 1, 'Gestion Produccion', 'Produccion', 1),
(2, 1, 'configuraciones_inventarios', 'Configurar inventarios', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacora`
--

CREATE TABLE `tbl_bitacora` (
  `PK_id_bitacora` int(11) NOT NULL,
  `PK_id_usuario` varchar(25) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `host` varchar(45) DEFAULT NULL,
  `ip` varchar(25) DEFAULT NULL,
  `accion` varchar(50) DEFAULT NULL,
  `tabla` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_bitacora`
--

INSERT INTO `tbl_bitacora` (`PK_id_bitacora`, `PK_id_usuario`, `fecha`, `hora`, `host`, `ip`, `accion`, `tabla`) VALUES
(3, 'edgar1', '2020-04-16', '07:49:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(4, 'edgar1', '2020-04-16', '07:57:47', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(5, 'edgar1', '2020-04-16', '07:57:59', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a modulos', 'tbl_modulos'),
(6, 'edgar1', '2020-04-16', '07:58:51', 'DESKTOP-A5I55KB', '192.168.1.9', 'Inserto un nuevo modulo: 1 - MRP', 'tbl_modulo'),
(7, 'edgar1', '2020-04-16', '07:59:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Inserto un nuevo perfil: 1 - Administrador', 'tbl_perfil'),
(8, 'edgar1', '2020-04-16', '07:59:23', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a modulos', 'tbl_modulos'),
(9, 'edgar1', '2020-04-16', '08:00:02', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(10, 'edgar1', '2020-04-16', '08:00:02', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a modulos', 'tbl_modulos'),
(11, 'edgar1', '2020-04-16', '08:00:18', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(12, 'edgar1', '2020-04-16', '08:00:32', 'DESKTOP-A5I55KB', '192.168.1.9', 'Asigno aplicacion: Gestion Produccion a usuario: e', 'tbl_usuario_aplicacion'),
(13, 'edgar1', '2020-04-16', '08:00:43', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(14, 'edgar1', '2020-04-16', '08:00:43', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(15, 'edgar1', '2020-04-16', '08:00:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(16, 'edgar1', '2020-04-16', '08:01:01', 'DESKTOP-A5I55KB', '192.168.1.9', 'Asigno perfil: Administrador a usuario: edgar1', 'tbl_usuario_perfil'),
(17, 'edgar1', '2020-04-16', '08:01:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(18, 'edgar1', '2020-04-16', '08:01:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a modulos', 'tbl_modulos'),
(19, 'edgar1', '2020-04-16', '08:01:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(20, 'edgar1', '2020-04-16', '08:01:37', 'DESKTOP-A5I55KB', '192.168.1.9', 'Asigno permiso: Gestion Produccion a perfil: Admin', 'tbl_usuario_aplicacion'),
(21, 'edgar1', '2020-04-16', '08:01:50', 'DESKTOP-A5I55KB', '192.168.1.9', 'Probo la bitacora', 'Usuarios'),
(22, 'edgar1', '2020-04-16', '08:05:52', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(23, 'edgar1', '2020-04-16', '08:09:25', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(24, 'edgar1', '2020-04-16', '08:11:16', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(25, 'edgar1', '2020-04-16', '08:12:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(26, 'edgar1', '2020-04-16', '08:14:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'registro_horas_emp'),
(27, 'edgar1', '2020-04-16', '08:21:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(28, 'edgar1', '2020-04-16', '08:46:30', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(29, 'edgar1', '2020-04-16', '09:00:58', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(30, 'edgar1', '2020-04-16', '09:05:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(31, 'edgar1', '2020-04-16', '09:19:14', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(32, 'edgar1', '2020-04-16', '09:22:29', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(33, 'edgar1', '2020-04-16', '09:26:01', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(34, 'edgar1', '2020-04-16', '09:50:30', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(35, 'edgar1', '2020-04-17', '12:22:30', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(36, 'edgar1', '2020-04-17', '12:24:25', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(37, 'edgar1', '2020-04-17', '12:26:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(38, 'edgar1', '2020-04-17', '12:27:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(39, 'edgar1', '2020-04-17', '12:33:10', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(40, 'edgar1', '2020-04-17', '12:37:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(41, 'edgar1', '2020-04-17', '12:50:29', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(42, 'edgar1', '2020-04-17', '01:03:30', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(43, 'edgar1', '2020-04-17', '01:06:17', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(44, 'edgar1', '2020-04-17', '01:15:58', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(45, 'edgar1', '2020-04-17', '01:21:52', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(46, 'edgar1', '2020-04-17', '01:22:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(47, 'edgar1', '2020-04-17', '01:36:14', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(48, 'edgar1', '2020-04-17', '01:39:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(49, 'edgar1', '2020-04-17', '01:42:50', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(50, 'edgar1', '2020-04-17', '01:44:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(51, 'edgar1', '2020-04-17', '01:49:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(52, 'edgar1', '2020-04-17', '02:28:00', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(53, 'edgar1', '2020-04-17', '02:29:02', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(54, 'edgar1', '2020-04-17', '02:30:27', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(55, 'edgar1', '2020-04-17', '03:46:01', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(56, 'edgar1', '2020-04-17', '03:54:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(57, 'edgar1', '2020-04-17', '04:02:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(58, 'edgar1', '2020-04-17', '04:05:24', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(59, 'edgar1', '2020-04-17', '04:22:24', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(60, 'edgar1', '2020-04-17', '04:24:21', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(61, 'edgar1', '2020-04-17', '04:28:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(63, 'edgar1', '2020-04-17', '12:23:58', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(64, 'edgar1', '2020-04-17', '12:36:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(65, 'edgar1', '2020-04-17', '12:50:04', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(66, 'edgar1', '2020-04-17', '12:52:07', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(67, 'edgar1', '2020-04-17', '12:52:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(68, 'edgar1', '2020-04-17', '12:52:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(69, 'edgar1', '2020-04-17', '12:52:46', 'DESKTOP-A5I55KB', '192.168.1.9', 'Realizo una consulta a modulos', 'tbl_modulos'),
(70, 'edgar1', '2020-04-17', '01:00:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(71, 'edgar1', '2020-04-17', '01:02:17', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(72, 'edgar1', '2020-04-17', '01:03:46', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(73, 'edgar1', '2020-04-17', '01:23:55', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(74, 'edgar1', '2020-04-17', '01:24:36', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(75, 'edgar1', '2020-04-17', '01:26:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(76, 'edgar1', '2020-04-17', '01:29:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(77, 'edgar1', '2020-04-17', '01:30:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(78, 'edgar1', '2020-04-17', '01:34:55', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(79, 'edgar1', '2020-04-17', '01:50:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(80, 'edgar1', '2020-04-17', '02:36:42', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(81, 'edgar1', '2020-04-17', '02:43:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(82, 'edgar1', '2020-04-17', '03:14:31', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(83, 'edgar1', '2020-04-17', '03:15:07', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(84, 'edgar1', '2020-04-17', '04:08:22', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(85, 'edgar1', '2020-04-17', '04:11:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(86, 'edgar1', '2020-04-17', '04:19:14', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(87, 'edgar1', '2020-04-17', '04:22:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(88, 'edgar1', '2020-04-17', '04:32:18', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(89, 'edgar1', '2020-04-17', '04:34:35', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(90, 'edgar1', '2020-04-17', '04:37:44', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(91, 'edgar1', '2020-04-17', '04:38:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(92, 'edgar1', '2020-04-17', '04:40:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(93, 'edgar1', '2020-04-17', '04:45:26', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(94, 'edgar1', '2020-04-17', '04:47:21', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(95, 'edgar1', '2020-04-17', '04:48:50', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(96, 'edgar1', '2020-04-17', '04:52:07', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(97, 'edgar1', '2020-04-17', '04:56:04', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(98, 'edgar1', '2020-04-17', '05:11:56', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(99, 'edgar1', '2020-04-17', '05:12:25', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(100, 'edgar1', '2020-04-17', '05:13:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(101, 'edgar1', '2020-04-17', '05:15:29', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(102, 'edgar1', '2020-04-17', '05:22:20', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(103, 'edgar1', '2020-04-17', '05:29:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(104, 'edgar1', '2020-04-17', '05:50:04', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(105, 'edgar1', '2020-04-17', '05:50:52', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(106, 'edgar1', '2020-04-17', '05:51:35', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(107, 'edgar1', '2020-04-17', '07:25:07', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(108, 'edgar1', '2020-04-17', '07:31:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(109, 'edgar1', '2020-04-17', '07:32:04', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(110, 'edgar1', '2020-04-17', '07:37:42', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(111, 'edgar1', '2020-04-17', '07:43:38', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(112, 'edgar1', '2020-04-17', '07:45:53', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(113, 'edgar1', '2020-04-17', '08:00:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(114, 'edgar1', '2020-04-17', '08:53:03', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(115, 'edgar1', '2020-04-17', '08:53:16', 'DESKTOP-A5I55KB', '192.168.1.9', 'Probo la bitacora', 'Usuarios'),
(116, 'edgar1', '2020-04-17', '08:54:35', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'cliente'),
(117, 'edgar1', '2020-04-17', '08:55:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(118, 'edgar1', '2020-04-17', '09:10:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(119, 'edgar1', '2020-04-17', '09:11:25', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(120, 'edgar1', '2020-04-17', '09:12:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(121, 'edgar1', '2020-04-17', '09:13:12', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(122, 'edgar1', '2020-04-17', '09:16:31', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(123, 'edgar1', '2020-04-17', '09:27:13', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(124, 'edgar1', '2020-04-17', '09:27:55', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(125, 'edgar1', '2020-04-17', '09:28:30', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'empleado'),
(126, 'edgar1', '2020-04-17', '09:30:05', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(127, 'edgar1', '2020-04-17', '09:31:23', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(128, 'edgar1', '2020-04-17', '09:32:35', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(129, 'edgar1', '2020-04-17', '09:33:03', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'empleado'),
(130, 'edgar1', '2020-04-17', '09:34:43', 'DESKTOP-A5I55KB', '192.168.1.9', 'Probo la bitacora', 'Usuarios'),
(131, 'edgar1', '2020-04-18', '08:28:10', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(132, 'edgar1', '2020-04-18', '08:34:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(133, 'edgar1', '2020-04-18', '08:36:00', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(134, 'edgar1', '2020-04-18', '08:38:14', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(135, 'edgar1', '2020-04-18', '08:38:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Ingreso ', 'Usuarios'),
(136, 'edgar1', '2020-04-18', '09:24:32', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(137, 'edgar1', '2020-04-18', '09:29:26', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(138, 'edgar1', '2020-04-18', '09:35:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(139, 'edgar1', '2020-04-18', '09:36:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(140, 'edgar1', '2020-04-18', '09:42:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(141, 'edgar1', '2020-04-18', '10:03:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(142, 'edgar1', '2020-04-18', '10:05:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(143, 'edgar1', '2020-04-18', '10:08:22', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(144, 'edgar1', '2020-04-18', '10:40:04', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(145, 'edgar1', '2020-04-18', '10:45:17', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(146, 'edgar1', '2020-04-18', '10:51:12', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(147, 'edgar1', '2020-04-18', '10:53:31', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(148, 'edgar1', '2020-04-18', '10:58:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(149, 'edgar1', '2020-04-18', '11:00:14', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(150, 'edgar1', '2020-04-18', '11:09:37', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(151, 'edgar1', '2020-04-18', '11:12:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(152, 'edgar1', '2020-04-18', '11:15:22', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(153, 'edgar1', '2020-04-18', '11:21:07', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(154, 'edgar1', '2020-04-18', '11:28:21', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(155, 'edgar1', '2020-04-19', '01:00:47', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(156, 'edgar1', '2020-04-19', '01:46:33', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(157, 'edgar1', '2020-04-19', '01:46:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(158, 'edgar1', '2020-04-19', '02:04:57', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(159, 'edgar1', '2020-04-19', '02:10:57', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(160, 'edgar1', '2020-04-19', '02:16:05', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(161, 'edgar1', '2020-04-19', '02:23:05', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(162, 'edgar1', '2020-04-19', '02:26:32', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(163, 'edgar1', '2020-04-19', '03:48:12', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(164, 'edgar1', '2020-04-19', '03:50:56', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(165, 'edgar1', '2020-04-19', '03:51:47', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(166, 'edgar1', '2020-04-19', '03:54:43', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(167, 'edgar1', '2020-04-19', '03:57:04', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(168, 'edgar1', '2020-04-19', '03:57:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(169, 'edgar1', '2020-04-19', '03:59:26', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(170, 'edgar1', '2020-04-19', '04:10:36', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(171, 'edgar1', '2020-04-19', '04:14:03', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(172, 'edgar1', '2020-04-19', '04:18:58', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(173, 'edgar1', '2020-04-19', '04:23:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(174, 'edgar1', '2020-04-19', '04:24:13', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(175, 'edgar1', '2020-04-19', '04:30:18', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(176, 'edgar1', '2020-04-19', '07:21:30', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(177, 'edgar1', '2020-04-19', '07:23:42', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(178, 'edgar1', '2020-04-19', '11:39:26', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(179, 'edgar1', '2020-04-20', '12:42:01', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(180, 'edgar1', '2020-04-20', '01:00:16', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(181, 'edgar1', '2020-04-20', '01:05:10', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(182, 'edgar1', '2020-04-20', '01:08:14', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(183, 'edgar1', '2020-04-20', '01:12:38', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(184, 'edgar1', '2020-04-20', '01:32:01', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(185, 'edgar1', '2020-04-20', '01:36:20', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(186, 'edgar1', '2020-04-20', '01:44:50', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(187, 'edgar1', '2020-04-20', '01:48:35', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(188, 'edgar1', '2020-04-20', '01:49:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(189, 'edgar1', '2020-04-20', '01:51:50', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(190, 'edgar1', '2020-04-20', '01:52:56', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'registro_horas_emp'),
(191, 'edgar1', '2020-04-20', '01:55:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(192, 'edgar1', '2020-04-20', '02:09:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(193, 'edgar1', '2020-04-20', '02:11:35', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(194, 'edgar1', '2020-04-20', '05:49:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(195, 'edgar1', '2020-04-20', '05:53:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(196, 'edgar1', '2020-04-20', '06:05:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(197, 'edgar1', '2020-04-21', '12:18:09', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(198, 'edgar1', '2020-04-21', '01:54:03', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(199, 'edgar1', '2020-04-21', '01:57:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(200, 'edgar1', '2020-04-21', '02:02:38', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(201, 'edgar1', '2020-04-21', '02:17:06', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(202, 'edgar1', '2020-04-21', '02:26:21', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(203, 'edgar1', '2020-04-21', '02:28:38', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(204, 'edgar1', '2020-04-21', '02:32:32', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(205, 'edgar1', '2020-04-21', '02:34:25', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(206, 'edgar1', '2020-04-21', '02:35:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(207, 'edgar1', '2020-04-21', '06:24:57', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(208, 'edgar1', '2020-04-21', '06:31:39', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(209, 'edgar1', '2020-04-21', '06:49:16', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(210, 'edgar1', '2020-04-21', '06:51:58', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(211, 'edgar1', '2020-04-21', '06:53:01', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(212, 'edgar1', '2020-04-21', '07:09:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(213, 'edgar1', '2020-04-21', '07:11:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(214, 'edgar1', '2020-04-21', '07:12:53', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(215, 'edgar1', '2020-04-21', '07:13:36', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(216, 'edgar1', '2020-04-21', '07:14:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(217, 'edgar1', '2020-04-21', '08:06:22', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(218, 'edgar1', '2020-04-21', '08:11:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(219, 'edgar1', '2020-04-21', '08:25:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(220, 'edgar1', '2020-04-21', '08:34:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(221, 'edgar1', '2020-04-21', '08:37:50', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(222, 'edgar1', '2020-04-21', '08:43:55', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(223, 'edgar1', '2020-04-21', '08:46:53', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(224, 'edgar1', '2020-04-21', '08:49:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(225, 'edgar1', '2020-04-21', '09:01:07', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(226, 'edgar1', '2020-04-21', '09:02:27', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(227, 'edgar1', '2020-04-21', '11:15:46', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(228, 'edgar1', '2020-04-21', '11:36:29', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(229, 'edgar1', '2020-04-21', '11:41:39', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(230, 'edgar1', '2020-04-21', '11:58:36', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(231, 'edgar1', '2020-04-22', '12:00:50', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(232, 'edgar1', '2020-04-22', '12:02:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(233, 'edgar1', '2020-04-22', '12:09:21', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(234, 'edgar1', '2020-04-22', '12:15:49', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(235, 'edgar1', '2020-04-22', '12:57:10', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(236, 'edgar1', '2020-04-22', '01:01:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(237, 'edgar1', '2020-04-22', '01:06:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(238, 'edgar1', '2020-04-22', '01:25:43', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(239, 'edgar1', '2020-04-22', '01:27:01', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(240, 'edgar1', '2020-04-22', '01:39:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(241, 'edgar1', '2020-04-22', '01:40:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(242, 'edgar1', '2020-04-22', '01:44:27', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(243, 'edgar1', '2020-04-22', '09:35:43', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(244, 'edgar1', '2020-04-22', '09:50:17', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(245, 'edgar1', '2020-04-22', '09:53:14', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(246, 'edgar1', '2020-04-22', '09:54:29', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(247, 'edgar1', '2020-04-22', '10:04:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(248, 'edgar1', '2020-04-22', '10:06:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(249, 'edgar1', '2020-04-22', '10:07:17', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'puesto'),
(250, 'edgar1', '2020-04-22', '10:07:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'puesto'),
(251, 'edgar1', '2020-04-22', '10:08:32', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'puesto'),
(252, 'edgar1', '2020-04-22', '10:08:52', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'puesto'),
(253, 'edgar1', '2020-04-22', '10:09:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'departamento'),
(254, 'edgar1', '2020-04-22', '10:09:21', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'departamento'),
(255, 'edgar1', '2020-04-22', '10:09:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'departamento'),
(256, 'edgar1', '2020-04-22', '10:09:52', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'departamento'),
(257, 'edgar1', '2020-04-22', '10:11:05', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(258, 'edgar1', '2020-04-22', '10:12:42', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'concepto'),
(259, 'edgar1', '2020-04-22', '10:13:03', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'concepto'),
(260, 'edgar1', '2020-04-22', '10:13:26', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'concepto'),
(261, 'edgar1', '2020-04-22', '10:13:39', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'concepto'),
(262, 'edgar1', '2020-04-22', '10:14:04', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'concepto'),
(263, 'edgar1', '2020-04-22', '10:14:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'empleado'),
(264, 'edgar1', '2020-04-22', '10:15:21', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'empleado'),
(265, 'edgar1', '2020-04-22', '10:15:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'empleado'),
(266, 'edgar1', '2020-04-22', '11:14:37', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(267, 'edgar1', '2020-04-22', '11:19:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(268, 'edgar1', '2020-04-22', '11:20:59', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(269, 'edgar1', '2020-04-22', '11:25:03', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(270, 'edgar1', '2020-04-22', '11:26:53', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(271, 'edgar1', '2020-04-22', '11:27:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'empleado'),
(272, 'edgar1', '2020-04-22', '11:27:31', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'empleado'),
(273, 'edgar1', '2020-04-22', '11:27:42', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'empleado'),
(274, 'edgar1', '2020-04-22', '11:27:53', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'empleado'),
(275, 'edgar1', '2020-04-22', '11:28:05', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'concepto'),
(276, 'edgar1', '2020-04-22', '11:28:18', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'concepto'),
(277, 'edgar1', '2020-04-22', '11:28:29', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'concepto'),
(278, 'edgar1', '2020-04-22', '11:28:37', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'concepto'),
(279, 'edgar1', '2020-04-22', '11:28:43', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'concepto'),
(280, 'edgar1', '2020-04-22', '11:28:55', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'departamento'),
(281, 'edgar1', '2020-04-22', '11:29:02', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'departamento'),
(282, 'edgar1', '2020-04-22', '11:29:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'departamento'),
(283, 'edgar1', '2020-04-22', '11:29:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'departamento'),
(284, 'edgar1', '2020-04-22', '11:29:23', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'departamento'),
(285, 'edgar1', '2020-04-22', '11:31:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(286, 'edgar1', '2020-04-22', '11:37:42', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(287, 'edgar1', '2020-04-22', '11:38:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(288, 'edgar1', '2020-04-22', '11:41:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(289, 'edgar1', '2020-04-22', '11:42:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(290, 'edgar1', '2020-04-22', '11:43:19', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(291, 'edgar1', '2020-04-22', '11:45:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(292, 'edgar1', '2020-04-22', '11:47:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(293, 'edgar1', '2020-04-22', '11:49:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(294, 'edgar1', '2020-04-22', '11:51:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(295, 'edgar1', '2020-04-22', '11:58:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(296, 'edgar1', '2020-04-22', '12:00:13', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(297, 'edgar1', '2020-04-22', '12:21:39', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(298, 'edgar1', '2020-04-22', '01:07:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(299, 'edgar1', '2020-04-22', '01:26:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(300, 'edgar1', '2020-04-22', '02:09:00', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(301, 'edgar1', '2020-04-23', '05:52:21', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(302, 'edgar1', '2020-04-23', '08:01:29', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(303, 'edgar1', '2020-04-24', '12:23:55', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(304, 'edgar1', '2020-04-24', '12:24:51', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'detalles_recetas'),
(305, 'edgar1', '2020-04-24', '12:25:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'detalles_recetas'),
(306, 'edgar1', '2020-04-24', '12:26:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'detalles_recetas'),
(307, 'edgar1', '2020-04-24', '12:26:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'detalles_recetas'),
(308, 'edgar1', '2020-04-24', '12:30:54', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(309, 'edgar1', '2020-04-24', '12:33:47', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(310, 'edgar1', '2020-04-24', '12:34:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'detalles_recetas'),
(311, 'edgar1', '2020-04-24', '12:34:56', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'detalles_recetas'),
(312, 'edgar1', '2020-04-24', '03:40:47', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(313, 'edgar1', '2020-04-24', '03:42:28', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'productos'),
(314, 'edgar1', '2020-04-24', '03:44:32', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'productos'),
(315, 'edgar1', '2020-04-24', '03:45:15', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'productos'),
(316, 'edgar1', '2020-04-24', '03:46:09', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'productos'),
(317, 'edgar1', '2020-04-24', '03:47:34', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'productos'),
(318, 'edgar1', '2020-04-24', '03:49:08', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'productos'),
(319, 'edgar1', '2020-04-24', '03:50:37', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se creó un nuevo registro', 'productos'),
(320, 'edgar1', '2020-04-24', '03:53:59', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(321, 'edgar1', '2020-04-24', '03:55:32', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'productos'),
(322, 'edgar1', '2020-04-24', '03:56:14', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'productos'),
(323, 'edgar1', '2020-04-24', '03:58:45', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'productos'),
(324, 'edgar1', '2020-04-24', '03:59:07', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'productos'),
(325, 'edgar1', '2020-04-24', '04:01:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'productos'),
(326, 'edgar1', '2020-04-24', '04:01:33', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'productos'),
(327, 'edgar1', '2020-04-24', '04:01:48', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se actualizó un registro', 'productos'),
(328, 'edgar1', '2020-04-24', '06:32:00', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(329, 'edgar1', '2020-04-24', '06:41:07', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(330, 'edgar1', '2020-04-24', '06:42:11', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(331, 'edgar1', '2020-04-24', '06:59:20', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(332, 'edgar1', '2020-04-24', '07:01:20', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(333, 'edgar1', '2020-04-24', '07:09:12', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(334, 'edgar1', '2020-04-24', '07:37:59', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(335, 'edgar1', '2020-04-24', '07:39:09', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(336, 'edgar1', '2020-04-24', '07:40:40', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(337, 'edgar1', '2020-04-24', '07:52:59', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(338, 'edgar1', '2020-04-24', '08:01:56', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(339, 'edgar1', '2020-04-24', '08:23:41', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(340, 'edgar1', '2020-04-24', '08:42:36', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(341, 'edgar1', '2020-04-24', '09:04:04', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(342, 'edgar1', '2020-04-24', '09:17:29', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(343, 'edgar1', '2020-04-24', '09:28:59', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(344, 'edgar1', '2020-04-24', '09:35:00', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(345, 'edgar1', '2020-04-24', '10:04:05', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(346, 'edgar1', '2020-04-24', '10:11:33', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(347, 'edgar1', '2020-04-24', '11:06:04', 'DESKTOP-A5I55KB', '127.0.0.1', 'Se logeo al sistema', 'Login'),
(348, 'edgar1', '2020-04-24', '11:08:13', 'DESKTOP-A5I55KB', '127.0.0.1', 'Se logeo al sistema', 'Login'),
(349, 'edgar1', '2020-04-24', '11:21:12', 'DESKTOP-A5I55KB', '127.0.0.1', 'Se logeo al sistema', 'Login'),
(350, 'edgar1', '2020-04-24', '11:40:58', 'DESKTOP-A5I55KB', '127.0.0.1', 'Se logeo al sistema', 'Login'),
(351, 'edgar1', '2020-04-24', '11:42:18', 'DESKTOP-A5I55KB', '127.0.0.1', 'Se logeo al sistema', 'Login'),
(352, 'edgar1', '2020-04-24', '11:48:30', 'DESKTOP-A5I55KB', '127.0.0.1', 'Se logeo al sistema', 'Login'),
(353, 'edgar1', '2020-04-24', '11:59:28', 'DESKTOP-A5I55KB', '127.0.0.1', 'Se logeo al sistema', 'Login'),
(354, 'edgar1', '2020-04-25', '12:18:52', 'DESKTOP-A5I55KB', '127.0.0.1', 'Se logeo al sistema', 'Login'),
(355, 'edgar1', '2020-04-25', '02:33:32', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(356, 'edgar1', '2020-04-25', '02:34:59', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(357, 'edgar1', '2020-04-25', '02:35:30', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(358, 'edgar1', '2020-04-25', '12:25:58', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(359, 'edgar1', '2020-04-25', '12:33:18', 'DESKTOP-A5I55KB', '192.168.1.9', 'Se logeo al sistema', 'Login'),
(360, 'edgar1', '2020-04-25', '11:47:53', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(361, 'edgar1', '2020-04-25', '11:52:48', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(362, 'edgar1', '2020-04-26', '12:36:18', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(363, 'edgar1', '2020-04-26', '12:41:52', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'productos'),
(364, 'edgar1', '2020-04-26', '01:20:44', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(365, 'edgar1', '2020-04-26', '01:22:52', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'productos'),
(366, 'edgar1', '2020-04-26', '01:23:34', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se actualizó un registro', 'productos'),
(367, 'edgar1', '2020-04-26', '01:27:31', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(368, 'edgar1', '2020-04-26', '01:28:15', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'productos'),
(369, 'edgar1', '2020-04-26', '01:30:31', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(370, 'edgar1', '2020-04-26', '01:36:16', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(371, 'edgar1', '2020-04-26', '01:38:33', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(372, 'edgar1', '2020-04-26', '01:43:46', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(373, 'edgar1', '2020-04-26', '01:52:40', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(374, 'edgar1', '2020-04-26', '01:53:59', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'productos'),
(375, 'edgar1', '2020-04-26', '02:04:29', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(376, 'edgar1', '2020-04-26', '02:06:10', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(377, 'edgar1', '2020-04-26', '12:48:04', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(378, 'edgar1', '2020-04-26', '12:54:36', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(379, 'edgar1', '2020-04-26', '12:56:17', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(380, 'edgar1', '2020-04-26', '01:09:06', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(381, 'edgar1', '2020-04-26', '01:10:06', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(382, 'edgar1', '2020-04-26', '01:41:35', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(383, 'edgar1', '2020-04-26', '01:43:08', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(384, 'edgar1', '2020-04-26', '01:43:41', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(385, 'edgar1', '2020-04-26', '01:44:16', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(386, 'edgar1', '2020-04-26', '02:11:40', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(387, 'edgar1', '2020-04-26', '02:13:01', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(388, 'edgar1', '2020-04-26', '02:39:09', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(389, 'edgar1', '2020-04-26', '02:41:22', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(390, 'edgar1', '2020-04-26', '02:42:53', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(391, 'edgar1', '2020-04-26', '06:15:11', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(392, 'edgar1', '2020-04-26', '06:16:41', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(393, 'edgar1', '2020-04-26', '06:23:41', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(394, 'edgar1', '2020-04-26', '06:25:03', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(395, 'edgar1', '2020-04-26', '06:27:17', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(396, 'edgar1', '2020-04-26', '07:29:31', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(397, 'edgar1', '2020-04-26', '07:35:23', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(398, 'edgar1', '2020-04-26', '07:38:13', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(399, 'edgar1', '2020-04-26', '07:39:44', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(400, 'edgar1', '2020-04-26', '07:42:05', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(401, 'edgar1', '2020-04-26', '07:44:40', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(402, 'edgar1', '2020-04-26', '07:47:45', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(403, 'edgar1', '2020-04-26', '07:49:31', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(404, 'edgar1', '2020-04-26', '07:51:56', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(405, 'edgar1', '2020-04-26', '07:54:40', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(406, 'edgar1', '2020-04-26', '07:55:21', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(407, 'edgar1', '2020-04-26', '07:57:32', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(408, 'edgar1', '2020-04-26', '08:05:23', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(409, 'edgar1', '2020-04-26', '08:09:11', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'registro_horas_emp'),
(410, 'edgar1', '2020-04-28', '07:05:20', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(411, 'edgar1', '2020-04-29', '10:45:46', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(412, 'edgar1', '2020-04-29', '10:46:54', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(413, 'edgar1', '2020-04-29', '10:56:19', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(414, 'edgar1', '2020-04-29', '10:58:20', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(415, 'edgar1', '2020-04-29', '10:59:31', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(416, 'edgar1', '2020-04-29', '11:03:01', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(417, 'edgar1', '2020-04-29', '11:03:42', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'alumnos'),
(418, 'edgar1', '2020-04-29', '11:04:02', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'alumnos'),
(419, 'edgar1', '2020-04-29', '11:04:22', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'cursos'),
(420, 'edgar1', '2020-04-29', '11:04:34', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'cursos'),
(421, 'edgar1', '2020-04-29', '11:04:44', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'cursos'),
(422, 'edgar1', '2020-04-29', '11:05:00', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'cursos'),
(423, 'edgar1', '2020-04-29', '11:05:13', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'cursos'),
(424, 'edgar1', '2020-04-29', '11:06:42', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'secciones'),
(425, 'edgar1', '2020-04-29', '11:06:49', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'secciones'),
(426, 'edgar1', '2020-04-29', '11:06:53', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'secciones'),
(427, 'edgar1', '2020-04-29', '11:07:01', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'secciones'),
(428, 'edgar1', '2020-04-29', '11:08:51', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(429, 'edgar1', '2020-04-29', '11:09:27', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'maestros'),
(430, 'edgar1', '2020-04-29', '11:09:49', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'maestros'),
(431, 'edgar1', '2020-04-29', '11:10:08', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'maestros'),
(432, 'edgar1', '2020-04-29', '11:15:24', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(433, 'edgar1', '2020-04-29', '12:12:19', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(434, 'edgar1', '2020-04-29', '12:12:36', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'facultades'),
(435, 'edgar1', '2020-04-29', '12:12:57', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'carreras'),
(436, 'edgar1', '2020-04-29', '12:13:13', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'aulas'),
(437, 'edgar1', '2020-04-29', '12:13:46', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(438, 'edgar1', '2020-04-29', '12:13:58', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'jornadas'),
(439, 'edgar1', '2020-04-29', '12:14:18', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se creó un nuevo registro', 'sedes'),
(440, 'edgar1', '2020-04-29', '12:16:34', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(441, 'edgar1', '2020-04-29', '12:17:38', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(442, 'edgar1', '2020-04-29', '12:20:30', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(443, 'edgar1', '2020-04-29', '12:23:35', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(444, 'edgar1', '2020-04-29', '12:31:34', 'DESKTOP-A5I55KB', '192.168.43.70', 'Se logeo al sistema', 'Login'),
(445, 'edgar1', '2020-04-30', '09:41:03', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(446, 'edgar1', '2020-04-30', '09:43:59', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(447, 'edgar1', '2020-04-30', '11:00:27', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(448, 'edgar1', '2020-04-30', '11:09:20', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(449, 'edgar1', '2020-04-30', '11:10:00', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(450, 'edgar1', '2020-04-30', '11:11:04', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(451, 'edgar1', '2020-04-30', '11:12:43', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(452, 'edgar1', '2020-04-30', '11:14:43', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(453, 'edgar1', '2020-04-30', '11:17:54', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(454, 'edgar1', '2020-04-30', '11:21:06', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(455, 'edgar1', '2020-04-30', '11:21:26', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(456, 'edgar1', '2020-04-30', '11:26:35', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(457, 'edgar1', '2020-04-30', '11:35:03', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(458, 'edgar1', '2020-04-30', '11:35:40', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login');
INSERT INTO `tbl_bitacora` (`PK_id_bitacora`, `PK_id_usuario`, `fecha`, `hora`, `host`, `ip`, `accion`, `tabla`) VALUES
(459, 'edgar1', '2020-04-30', '11:37:30', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(460, 'edgar1', '2020-04-30', '11:41:14', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(461, 'edgar1', '2020-04-30', '11:41:40', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(462, 'edgar1', '2020-04-30', '11:54:30', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(463, 'edgar1', '2020-04-30', '11:58:06', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(464, 'edgar1', '2020-04-30', '11:58:51', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(465, 'edgar1', '2020-05-01', '12:13:57', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(466, 'edgar1', '2020-05-01', '12:34:30', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(467, 'edgar1', '2020-05-01', '12:36:41', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(468, 'edgar1', '2020-05-01', '12:36:57', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(469, 'edgar1', '2020-05-01', '12:38:35', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(470, 'edgar1', '2020-05-01', '12:39:45', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(471, 'edgar1', '2020-05-01', '12:40:18', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(472, 'edgar1', '2020-05-01', '12:40:43', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(473, 'edgar1', '2020-05-01', '12:41:16', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(474, 'edgar1', '2020-05-01', '01:06:38', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(475, 'edgar1', '2020-05-01', '01:19:26', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(476, 'edgar1', '2020-05-01', '01:21:06', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(477, 'edgar1', '2020-05-01', '01:22:21', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(478, 'edgar1', '2020-05-01', '01:23:45', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(479, 'edgar1', '2020-05-01', '01:47:06', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(480, 'edgar1', '2020-05-01', '12:52:48', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(481, 'edgar1', '2020-05-01', '12:55:35', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(482, 'edgar1', '2020-05-01', '02:50:12', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(483, 'edgar1', '2020-05-01', '02:50:56', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(484, 'edgar1', '2020-05-01', '09:14:39', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(485, 'edgar1', '2020-05-01', '09:18:40', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(486, 'edgar1', '2020-05-01', '09:35:36', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(487, 'edgar1', '2020-05-01', '09:38:04', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(488, 'edgar1', '2020-05-01', '09:39:24', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(489, 'edgar1', '2020-05-01', '11:46:08', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(490, 'edgar1', '2020-05-01', '11:48:25', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(491, 'edgar1', '2020-05-01', '11:51:28', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(492, 'edgar1', '2020-05-01', '11:56:12', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(493, 'edgar1', '2020-05-01', '11:57:30', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(494, 'edgar1', '2020-05-02', '12:03:14', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(495, 'edgar1', '2020-05-02', '12:04:41', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(496, 'edgar1', '2020-05-02', '12:06:39', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(497, 'edgar1', '2020-05-02', '12:10:15', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(498, 'edgar1', '2020-05-02', '12:11:14', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(499, 'edgar1', '2020-05-02', '12:24:03', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(500, 'edgar1', '2020-05-02', '11:22:21', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(501, 'edgar1', '2020-05-02', '11:25:05', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(502, 'edgar1', '2020-05-02', '11:27:04', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(503, 'edgar1', '2020-05-03', '08:32:08', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(504, 'edgar1', '2020-05-04', '10:16:23', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(505, 'edgar1', '2020-05-04', '10:49:26', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(506, 'edgar1', '2020-05-04', '10:51:49', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(507, 'edgar1', '2020-05-04', '11:56:18', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(508, 'edgar1', '2020-05-05', '12:06:27', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(509, 'edgar1', '2020-05-05', '12:07:09', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(510, 'edgar1', '2020-05-05', '12:07:42', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(511, 'edgar1', '2020-05-05', '12:23:18', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(512, 'edgar1', '2020-05-05', '12:24:28', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(513, 'edgar1', '2020-05-05', '12:25:14', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(514, 'edgar1', '2020-05-05', '12:28:20', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(515, 'edgar1', '2020-05-05', '12:29:34', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(516, 'edgar1', '2020-05-05', '12:40:21', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(517, 'edgar1', '2020-05-05', '12:43:59', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(518, 'edgar1', '2020-05-05', '12:27:53', 'DESKTOP-A5I55KB', '192.168.1.8', 'Se logeo al sistema', 'Login'),
(519, 'edgar1', '2020-05-05', '11:32:53', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(520, 'edgar1', '2020-05-05', '11:34:29', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(521, 'edgar1', '2020-05-05', '11:42:21', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(522, 'edgar1', '2020-05-05', '11:58:01', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(523, 'edgar1', '2020-05-06', '12:08:40', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(524, 'edgar1', '2020-05-06', '12:09:48', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(525, 'edgar1', '2020-05-06', '12:11:58', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(526, 'edgar1', '2020-05-06', '12:13:21', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(527, 'edgar1', '2020-05-06', '12:22:53', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(528, 'edgar1', '2020-05-06', '12:25:48', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(529, 'edgar1', '2020-05-08', '08:47:21', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(530, 'edgar1', '2020-05-08', '10:25:23', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(531, 'edgar1', '2020-05-08', '10:55:57', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(532, 'edgar1', '2020-05-08', '10:58:04', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(533, 'edgar1', '2020-05-08', '11:07:17', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(534, 'edgar1', '2020-05-08', '11:10:33', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(535, 'edgar1', '2020-05-08', '11:23:43', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(536, 'edgar1', '2020-05-08', '11:25:34', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(537, 'edgar1', '2020-05-08', '11:26:11', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(538, 'edgar1', '2020-05-08', '11:33:04', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(539, 'edgar1', '2020-05-08', '11:36:07', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(540, 'edgar1', '2020-05-08', '11:39:38', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(541, 'edgar1', '2020-05-08', '11:50:33', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(542, 'edgar1', '2020-05-08', '11:53:55', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(543, 'edgar1', '2020-05-08', '11:58:34', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(544, 'edgar1', '2020-05-09', '12:05:20', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(545, 'edgar1', '2020-05-09', '12:06:11', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(546, 'edgar1', '2020-05-09', '12:08:38', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(547, 'edgar1', '2020-05-09', '12:23:27', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(548, 'edgar1', '2020-05-09', '03:20:40', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(549, 'edgar1', '2020-05-09', '03:53:44', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(550, 'edgar1', '2020-05-09', '03:54:32', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(551, 'edgar1', '2020-05-10', '11:50:32', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(552, 'edgar1', '2020-05-11', '02:19:22', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(553, 'edgar1', '2020-05-11', '02:22:33', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(554, 'edgar1', '2020-05-11', '02:24:04', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(555, 'edgar1', '2020-05-11', '02:25:25', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(556, 'edgar1', '2020-05-11', '02:44:58', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(557, 'edgar1', '2020-05-11', '02:45:34', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(558, 'edgar1', '2020-05-11', '02:47:27', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(559, 'edgar1', '2020-05-11', '03:00:04', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(560, 'edgar1', '2020-05-11', '03:01:43', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(561, 'edgar1', '2020-05-11', '03:04:03', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(562, 'edgar1', '2020-05-11', '09:13:04', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(563, 'edgar1', '2020-05-11', '10:23:20', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(564, 'edgar1', '2020-05-11', '10:23:59', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(565, 'edgar1', '2020-05-11', '10:25:33', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(566, 'edgar1', '2020-05-11', '10:27:18', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(567, 'edgar1', '2020-05-11', '10:33:56', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(568, 'edgar1', '2020-05-11', '10:38:31', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(569, 'edgar1', '2020-05-11', '10:40:22', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(570, 'edgar1', '2020-05-11', '10:43:49', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(571, 'edgar1', '2020-05-11', '10:46:38', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(572, 'edgar1', '2020-05-11', '10:48:11', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(573, 'edgar1', '2020-05-11', '10:54:37', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(574, 'edgar1', '2020-05-11', '10:55:30', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(575, 'edgar1', '2020-05-11', '11:03:33', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(576, 'edgar1', '2020-05-11', '11:11:53', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(577, 'edgar1', '2020-05-11', '11:34:13', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(578, 'edgar1', '2020-05-12', '12:03:12', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(579, 'edgar1', '2020-05-12', '12:44:26', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(580, 'edgar1', '2020-05-12', '12:46:53', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(581, 'edgar1', '2020-05-12', '12:50:00', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(582, 'edgar1', '2020-05-12', '01:05:10', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(583, 'edgar1', '2020-05-12', '01:07:02', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(584, 'edgar1', '2020-05-12', '01:09:03', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(585, 'edgar1', '2020-05-12', '01:11:11', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(586, 'edgar1', '2020-05-12', '01:23:57', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(587, 'edgar1', '2020-05-12', '01:28:48', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(588, 'edgar1', '2020-05-12', '01:37:31', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(589, 'edgar1', '2020-05-12', '10:11:20', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(590, 'edgar1', '2020-05-12', '10:16:28', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(591, 'edgar1', '2020-05-12', '10:25:10', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(592, 'edgar1', '2020-05-12', '11:05:21', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(593, 'edgar1', '2020-05-13', '01:17:00', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(594, 'edgar1', '2020-05-13', '09:08:36', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(595, 'edgar1', '2020-05-13', '10:44:02', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(596, 'edgar1', '2020-05-13', '10:47:49', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(597, 'edgar1', '2020-05-13', '10:49:37', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(598, 'edgar1', '2020-05-13', '10:51:03', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(599, 'edgar1', '2020-05-13', '10:53:36', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(600, 'edgar1', '2020-05-13', '10:55:05', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(601, 'edgar1', '2020-05-13', '10:55:36', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(602, 'edgar1', '2020-05-13', '10:56:45', 'DESKTOP-A5I55KB', '192.168.1.3', 'Se logeo al sistema', 'Login'),
(603, 'edgar1', '2020-05-13', '03:41:46', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(604, 'edgar1', '2020-05-13', '03:44:58', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(605, 'edgar1', '2020-05-13', '04:00:50', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(606, 'edgar1', '2020-05-13', '04:12:21', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(607, 'edgar1', '2020-05-13', '04:14:05', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(608, 'edgar1', '2020-05-13', '05:15:18', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(609, 'edgar1', '2020-05-13', '05:38:02', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(610, 'edgar1', '2020-05-13', '06:23:10', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(611, 'edgar1', '2020-05-13', '06:23:42', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(612, 'edgar1', '2020-05-13', '06:30:34', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(613, 'edgar1', '2020-05-13', '06:32:13', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(614, 'edgar1', '2020-05-13', '06:33:18', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(615, 'edgar1', '2020-05-13', '06:33:28', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(616, 'edgar1', '2020-05-13', '06:34:32', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'registro_horas_emp'),
(617, 'edgar1', '2020-05-13', '06:35:56', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(618, 'edgar1', '2020-05-13', '07:24:44', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(619, 'edgar1', '2020-05-13', '11:54:56', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(620, 'edgar1', '2020-05-14', '12:12:15', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(621, 'edgar1', '2020-05-14', '12:15:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(622, 'edgar1', '2020-05-14', '12:18:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(623, 'edgar1', '2020-05-14', '12:23:27', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(624, 'edgar1', '2020-05-14', '01:54:08', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(625, 'edgar1', '2020-05-14', '01:56:19', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(626, 'edgar1', '2020-05-14', '01:57:41', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(627, 'edgar1', '2020-05-14', '01:58:16', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'registro_horas_emp'),
(628, 'edgar1', '2020-05-14', '01:58:20', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'registro_horas_emp'),
(629, 'edgar1', '2020-05-14', '01:58:25', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'registro_horas_emp'),
(630, 'edgar1', '2020-05-14', '01:58:29', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'registro_horas_emp'),
(631, 'edgar1', '2020-05-14', '02:00:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(632, 'edgar1', '2020-05-14', '02:04:20', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(633, 'edgar1', '2020-05-14', '02:07:06', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(634, 'edgar1', '2020-05-14', '02:08:00', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(635, 'edgar1', '2020-05-14', '02:09:53', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(636, 'edgar1', '2020-05-14', '01:26:15', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(637, 'edgar1', '2020-05-14', '01:59:55', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(638, 'edgar1', '2020-05-14', '02:01:22', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(639, 'edgar1', '2020-05-14', '02:05:46', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(640, 'edgar1', '2020-05-14', '02:07:31', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(641, 'edgar1', '2020-05-14', '02:08:29', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(642, 'edgar1', '2020-05-14', '02:09:36', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(643, 'edgar1', '2020-05-14', '02:32:56', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(644, 'edgar1', '2020-05-14', '02:34:13', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(645, 'edgar1', '2020-05-14', '02:34:38', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(646, 'edgar1', '2020-05-14', '02:37:31', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(647, 'edgar1', '2020-05-14', '02:47:58', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(648, 'edgar1', '2020-05-14', '02:54:46', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(649, 'edgar1', '2020-05-14', '06:29:16', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(650, 'edgar1', '2020-05-14', '06:35:50', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se creó un nuevo registro', 'productos'),
(651, 'edgar1', '2020-05-14', '06:37:23', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se creó un nuevo registro', 'productos'),
(652, 'edgar1', '2020-05-14', '06:41:02', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se logeo al sistema', 'Login'),
(653, 'edgar1', '2020-05-14', '06:43:36', 'DESKTOP-A5I55KB', '192.168.1.2', 'Se creó un nuevo registro', 'registro_horas_emp'),
(654, 'edgar1', '2020-05-16', '08:39:25', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(655, 'edgar1', '2020-05-17', '01:54:50', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(656, 'edgar1', '2020-05-17', '02:05:35', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(657, 'edgar1', '2020-05-17', '02:15:03', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(658, 'edgar1', '2020-05-17', '02:50:59', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(659, 'edgar1', '2020-05-17', '02:52:24', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(660, 'edgar1', '2020-05-17', '02:56:04', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(661, 'edgar1', '2020-05-17', '02:57:32', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(662, 'edgar1', '2020-05-17', '03:42:15', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(663, 'edgar1', '2020-05-17', '03:53:15', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(664, 'edgar1', '2020-05-17', '03:53:41', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(665, 'edgar1', '2020-05-17', '03:54:31', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(666, 'edgar1', '2020-05-17', '04:09:31', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(667, 'edgar1', '2020-05-17', '04:26:30', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'productos'),
(668, 'edgar1', '2020-05-17', '04:27:02', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'productos'),
(669, 'edgar1', '2020-05-17', '04:32:39', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(670, 'edgar1', '2020-05-17', '04:33:35', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(671, 'edgar1', '2020-05-17', '04:36:28', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(672, 'edgar1', '2020-05-17', '04:44:14', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(673, 'edgar1', '2020-05-17', '04:49:20', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(674, 'edgar1', '2020-05-17', '04:51:55', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(675, 'edgar1', '2020-05-17', '06:47:25', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(676, 'edgar1', '2020-05-17', '07:12:25', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(678, 'edgar1', '2020-05-17', '08:39:45', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(679, 'edgar1', '2020-05-17', '09:11:01', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(680, 'edgar1', '2020-05-17', '10:18:56', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(681, 'edgar1', '2020-05-17', '10:49:07', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(682, 'edgar1', '2020-05-17', '10:54:26', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(683, 'edgar1', '2020-05-17', '10:56:01', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(684, 'edgar1', '2020-05-17', '11:03:32', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(685, 'edgar1', '2020-05-17', '11:07:02', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(686, 'edgar1', '2020-05-17', '11:17:13', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a perfiles ', 'tbl_perfil'),
(687, 'edgar1', '2020-05-17', '11:17:24', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(688, 'edgar1', '2020-05-17', '11:17:36', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a perfiles ', 'tbl_perfil'),
(689, 'edgar1', '2020-05-17', '11:17:52', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(690, 'edgar1', '2020-05-17', '11:18:04', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a modulos', 'tbl_modulos'),
(691, 'edgar1', '2020-05-17', '11:18:13', 'DESKTOP-A5I55KB', '192.168.1.4', 'Consulto bitacora', 'tbl_bitacora'),
(692, 'edgar1', '2020-05-17', '11:18:48', 'DESKTOP-A5I55KB', '192.168.1.4', 'Ingreso ', 'Usuarios'),
(694, 'edgar1', '2020-05-17', '11:21:47', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(695, 'edgar1', '2020-05-17', '11:21:47', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a modulos', 'tbl_modulos'),
(696, 'edgar1', '2020-05-17', '11:21:52', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(697, 'edgar1', '2020-05-17', '11:22:10', 'DESKTOP-A5I55KB', '192.168.1.4', 'Asigno aplicacion: Gestion Produccion a usuario: e', 'tbl_usuario_aplicacion'),
(698, 'edgar1', '2020-05-17', '11:22:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(699, 'edgar1', '2020-05-17', '11:22:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(700, 'edgar1', '2020-05-17', '11:22:27', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(701, 'edgar1', '2020-05-17', '11:22:27', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a modulos', 'tbl_modulos'),
(702, 'edgar1', '2020-05-17', '11:22:36', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a modulos', 'tbl_modulos'),
(703, 'edgar1', '2020-05-17', '11:26:46', 'DESKTOP-A5I55KB', '192.168.1.4', 'Ingreso ', 'Usuarios'),
(705, 'edgar1', '2020-05-17', '11:32:13', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(706, 'edgar1', '2020-05-17', '11:36:24', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a modulos', 'tbl_modulos'),
(707, 'edgar1', '2020-05-17', '11:37:55', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a modulos', 'tbl_modulos'),
(708, 'edgar1', '2020-05-17', '11:38:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Inserto un nuevo perfil: 2 - usuario', 'tbl_perfil'),
(709, 'edgar1', '2020-05-17', '11:38:23', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(710, 'edgar1', '2020-05-17', '11:38:23', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a modulos', 'tbl_modulos'),
(711, 'edgar1', '2020-05-17', '11:38:30', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(712, 'edgar1', '2020-05-17', '11:38:45', 'DESKTOP-A5I55KB', '192.168.1.4', 'Asigno aplicacion: configuraciones_inventarios a u', 'tbl_usuario_aplicacion'),
(713, 'edgar1', '2020-05-17', '11:38:49', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(714, 'edgar1', '2020-05-17', '11:38:49', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(715, 'edgar1', '2020-05-17', '11:38:52', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(716, 'edgar1', '2020-05-17', '11:39:02', 'DESKTOP-A5I55KB', '192.168.1.4', 'Asigno perfil: Administrador a usuario: edgar1', 'tbl_usuario_perfil'),
(717, 'edgar1', '2020-05-17', '11:39:07', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(718, 'edgar1', '2020-05-17', '11:39:07', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a modulos', 'tbl_modulos'),
(719, 'edgar1', '2020-05-17', '11:39:11', 'DESKTOP-A5I55KB', '192.168.1.4', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(720, 'edgar1', '2020-05-17', '11:39:22', 'DESKTOP-A5I55KB', '192.168.1.4', 'Asigno permiso: configuraciones_inventarios a perf', 'tbl_usuario_aplicacion'),
(721, 'edgar1', '2020-05-17', '11:39:27', 'DESKTOP-A5I55KB', '192.168.1.4', 'Consulto bitacora', 'tbl_bitacora'),
(722, 'edgar1', '2020-05-17', '11:40:11', 'DESKTOP-A5I55KB', '192.168.1.4', 'Ingreso ', 'Usuarios'),
(723, 'edgar1', '2020-05-17', '11:42:07', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(724, 'edgar1', '2020-05-17', '11:44:22', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(725, 'edgar1', '2020-05-17', '11:45:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(726, 'edgar1', '2020-05-17', '11:47:50', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(727, 'edgar1', '2020-05-17', '11:51:44', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(728, 'edgar1', '2020-05-18', '12:48:46', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(729, 'edgar1', '2020-05-18', '01:09:08', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(730, 'edgar1', '2020-05-18', '01:11:28', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(731, 'edgar1', '2020-05-18', '01:39:53', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(732, 'edgar1', '2020-05-18', '01:41:58', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(733, 'edgar1', '2020-05-18', '01:48:15', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(734, 'edgar1', '2020-05-18', '01:50:39', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(735, 'edgar1', '2020-05-18', '01:52:58', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(736, 'edgar1', '2020-05-18', '01:55:49', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(737, 'edgar1', '2020-05-18', '01:59:11', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(738, 'edgar1', '2020-05-18', '02:02:53', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(739, 'edgar1', '2020-05-18', '02:05:47', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(740, 'edgar1', '2020-05-18', '02:08:56', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(741, 'edgar1', '2020-05-18', '08:41:23', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(742, 'edgar1', '2020-05-18', '08:43:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(743, 'edgar1', '2020-05-18', '08:51:34', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'registro_horas_emp'),
(744, 'edgar1', '2020-05-18', '08:57:42', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'productos'),
(745, 'edgar1', '2020-05-18', '08:58:40', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'productos'),
(746, 'edgar1', '2020-05-18', '08:58:59', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'productos'),
(747, 'edgar1', '2020-05-18', '08:59:23', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'productos'),
(748, 'edgar1', '2020-05-18', '09:25:49', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(749, 'edgar1', '2020-05-18', '12:24:08', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(750, 'edgar1', '2020-05-18', '12:24:29', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(751, 'edgar1', '2020-05-18', '12:55:23', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(752, 'edgar1', '2020-05-18', '12:57:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(753, 'edgar1', '2020-05-18', '12:59:27', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(754, 'edgar1', '2020-05-18', '01:00:55', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(755, 'edgar1', '2020-05-18', '01:03:16', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(756, 'edgar1', '2020-05-18', '01:08:36', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(757, 'edgar1', '2020-05-18', '01:11:45', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(758, 'edgar1', '2020-05-18', '01:37:23', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(759, 'edgar1', '2020-05-18', '01:39:40', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(760, 'edgar1', '2020-05-18', '01:46:06', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(761, 'edgar1', '2020-05-18', '01:48:14', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(762, 'edgar1', '2020-05-18', '01:50:08', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(763, 'edgar1', '2020-05-18', '02:00:20', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(764, 'edgar1', '2020-05-18', '02:04:51', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(765, 'edgar1', '2020-05-18', '02:05:58', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(766, 'edgar1', '2020-05-18', '02:08:00', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(767, 'edgar1', '2020-05-18', '02:10:25', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(768, 'edgar1', '2020-05-18', '02:19:14', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(769, 'edgar1', '2020-05-18', '02:24:18', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(770, 'edgar1', '2020-05-18', '02:26:36', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(771, 'edgar1', '2020-05-18', '02:38:38', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(772, 'edgar1', '2020-05-18', '02:44:19', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(773, 'edgar1', '2020-05-18', '02:49:01', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(774, 'edgar1', '2020-05-18', '02:50:56', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(775, 'edgar1', '2020-05-18', '02:54:49', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(776, 'edgar1', '2020-05-18', '02:59:02', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(777, 'edgar1', '2020-05-18', '03:00:30', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(778, 'edgar1', '2020-05-18', '03:02:21', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(779, 'edgar1', '2020-05-18', '03:59:34', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(780, 'edgar1', '2020-05-18', '04:38:31', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(781, 'edgar1', '2020-05-18', '04:39:05', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(782, 'edgar1', '2020-05-18', '04:40:41', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(783, 'edgar1', '2020-05-18', '04:58:10', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(784, 'edgar1', '2020-05-18', '04:59:01', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(785, 'edgar1', '2020-05-18', '05:00:28', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(786, 'edgar1', '2020-05-18', '05:04:43', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(787, 'edgar1', '2020-05-18', '05:10:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(788, 'edgar1', '2020-05-18', '05:14:09', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(789, 'edgar1', '2020-05-18', '05:14:50', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(790, 'edgar1', '2020-05-18', '05:17:59', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(791, 'edgar1', '2020-05-18', '05:19:57', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(792, 'edgar1', '2020-05-18', '05:28:29', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'productos'),
(793, 'edgar1', '2020-05-18', '05:28:33', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'productos'),
(794, 'edgar1', '2020-05-18', '05:28:38', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'productos'),
(795, 'edgar1', '2020-05-18', '05:28:44', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'productos'),
(796, 'edgar1', '2020-05-18', '05:28:49', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se eliminó un registro', 'productos'),
(797, 'edgar1', '2020-05-18', '05:29:24', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(798, 'edgar1', '2020-05-18', '05:49:08', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(799, 'edgar1', '2020-05-18', '06:18:35', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(800, 'edgar1', '2020-05-18', '06:20:06', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'productos'),
(801, 'edgar1', '2020-05-18', '06:20:49', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se creó un nuevo registro', 'productos'),
(802, 'edgar1', '2020-05-18', '06:25:17', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(803, 'edgar1', '2020-05-18', '06:27:18', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(804, 'edgar1', '2020-05-18', '06:29:36', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(805, 'edgar1', '2020-05-18', '06:30:00', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(806, 'edgar1', '2020-05-18', '06:31:53', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(807, 'edgar1', '2020-05-18', '06:32:15', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(808, 'edgar1', '2020-05-18', '06:38:02', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(809, 'edgar1', '2020-05-18', '06:38:23', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se actualizó un registro', 'registro_horas_emp'),
(810, 'edgar1', '2020-05-18', '06:46:53', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(811, 'edgar1', '2020-05-18', '06:51:16', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(812, 'edgar1', '2020-05-18', '06:52:05', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(813, 'edgar1', '2020-05-18', '07:16:35', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(814, 'edgar1', '2020-05-18', '07:31:15', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(815, 'edgar1', '2020-05-18', '07:37:14', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(816, 'edgar1', '2020-05-18', '07:49:42', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(817, 'edgar1', '2020-05-18', '07:52:03', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(818, 'edgar1', '2020-05-18', '08:09:00', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(819, 'edgar1', '2020-05-18', '08:09:50', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(820, 'edgar1', '2020-05-18', '08:14:08', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(821, 'edgar1', '2020-05-18', '08:15:01', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(822, 'edgar1', '2020-05-18', '08:21:56', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(823, 'edgar1', '2020-05-18', '08:22:08', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(824, 'edgar1', '2020-05-18', '08:23:29', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(825, 'edgar1', '2020-05-18', '08:24:25', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(826, 'edgar1', '2020-05-18', '08:39:32', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(827, 'edgar1', '2020-05-18', '08:44:01', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(828, 'edgar1', '2020-05-18', '08:48:22', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(829, 'edgar1', '2020-05-18', '08:57:31', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(830, 'edgar1', '2020-05-18', '09:18:08', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(831, 'edgar1', '2020-05-18', '09:19:06', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(832, 'edgar1', '2020-05-18', '09:21:43', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(833, 'edgar1', '2020-05-18', '09:22:52', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login'),
(834, 'edgar1', '2020-05-18', '09:23:37', 'DESKTOP-A5I55KB', '192.168.1.4', 'Se logeo al sistema', 'Login');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulo`
--

CREATE TABLE `tbl_modulo` (
  `PK_id_Modulo` int(11) NOT NULL,
  `nombre_modulo` varchar(45) DEFAULT NULL,
  `descripcion_modulo` varchar(200) DEFAULT NULL,
  `estado_modulo` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_modulo`
--

INSERT INTO `tbl_modulo` (`PK_id_Modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1, 'MRP', 'Produccion', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_detalle`
--

CREATE TABLE `tbl_perfil_detalle` (
  `PK_id_perfil` int(11) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_perfil_detalle`
--

INSERT INTO `tbl_perfil_detalle` (`PK_id_perfil`, `PK_id_aplicacion`, `ingresar`, `consultar`, `modificar`, `eliminar`, `imprimir`) VALUES
(1, 1, 1, 1, 1, 1, 1),
(1, 2, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_encabezado`
--

CREATE TABLE `tbl_perfil_encabezado` (
  `PK_id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(45) DEFAULT NULL,
  `descripcion_perfil` varchar(200) DEFAULT NULL,
  `estado_perfil` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_perfil_encabezado`
--

INSERT INTO `tbl_perfil_encabezado` (`PK_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'Administrador', 'administrar', 1),
(2, 'usuario', 'Solo puede ver o actuar', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE `tbl_usuario` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `nombre_usuario` varchar(45) DEFAULT NULL,
  `apellido_usuarios` varchar(45) DEFAULT NULL,
  `password_usuario` varchar(45) DEFAULT NULL,
  `cambio_contrasena` tinyint(4) DEFAULT NULL,
  `estado_usuario` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario`
--

INSERT INTO `tbl_usuario` (`PK_id_usuario`, `nombre_usuario`, `apellido_usuarios`, `password_usuario`, `cambio_contrasena`, `estado_usuario`) VALUES
('eddcas', 'edgar', 'casasola', '202cb962ac59075b964b07152d234b70', NULL, NULL),
('edgar1', 'edgar', 'casasola', '250cf8b51c773f3f8dc8b4be867a9a02', NULL, 1),
('edgar2', 'edgar', 'Casasola', '25d55ad283aa400af464c76d713c07ad', NULL, 1),
('MiUsuario', 'Usuario', 'Prueba', 'e19d5cd5af0378da05f63f891c7467af', 0, 1);

--
-- Disparadores `tbl_usuario`
--
DELIMITER $$
CREATE TRIGGER `actualizarClave` BEFORE UPDATE ON `tbl_usuario` FOR EACH ROW IF NEW.password_usuario <> OLD.password_usuario THEN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END IF
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `encriptarClave` BEFORE INSERT ON `tbl_usuario` FOR EACH ROW BEGIN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_aplicacion`
--

CREATE TABLE `tbl_usuario_aplicacion` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_perfil`
--

CREATE TABLE `tbl_usuario_perfil` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario_perfil`
--

INSERT INTO `tbl_usuario_perfil` (`PK_id_usuario`, `PK_id_perfil`) VALUES
('edgar1', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD PRIMARY KEY (`PK_id_aplicacion`,`PK_id_modulo`),
  ADD KEY `fk_Aplicacion_Modulo` (`PK_id_modulo`);

--
-- Indices de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD PRIMARY KEY (`PK_id_bitacora`,`PK_id_usuario`),
  ADD KEY `fk_Bitacora_Usuario1` (`PK_id_usuario`);

--
-- Indices de la tabla `tbl_modulo`
--
ALTER TABLE `tbl_modulo`
  ADD PRIMARY KEY (`PK_id_Modulo`);

--
-- Indices de la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD PRIMARY KEY (`PK_id_perfil`,`PK_id_aplicacion`),
  ADD KEY `fk_Perfil_detalle_Aplicacion1` (`PK_id_aplicacion`);

--
-- Indices de la tabla `tbl_perfil_encabezado`
--
ALTER TABLE `tbl_perfil_encabezado`
  ADD PRIMARY KEY (`PK_id_perfil`);

--
-- Indices de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`PK_id_usuario`);

--
-- Indices de la tabla `tbl_usuario_aplicacion`
--
ALTER TABLE `tbl_usuario_aplicacion`
  ADD PRIMARY KEY (`PK_id_usuario`,`PK_id_aplicacion`),
  ADD KEY `fk_tbl_usuario_aplicacion_tbl_aplicacion1` (`PK_id_aplicacion`);

--
-- Indices de la tabla `tbl_usuario_perfil`
--
ALTER TABLE `tbl_usuario_perfil`
  ADD PRIMARY KEY (`PK_id_usuario`,`PK_id_perfil`),
  ADD KEY `fk_Usuario_perfil_Perfil1` (`PK_id_perfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  MODIFY `PK_id_bitacora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=835;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD CONSTRAINT `fk_Aplicacion_Modulo` FOREIGN KEY (`PK_id_modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD CONSTRAINT `fk_Bitacora_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD CONSTRAINT `fk_Perfil_detalle_Aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Perfil_detalle_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_usuario_aplicacion`
--
ALTER TABLE `tbl_usuario_aplicacion`
  ADD CONSTRAINT `fk_Usuario_aplicacion_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_usuario_aplicacion_tbl_aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_usuario_perfil`
--
ALTER TABLE `tbl_usuario_perfil`
  ADD CONSTRAINT `fk_Usuario_perfil_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Usuario_perfil_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

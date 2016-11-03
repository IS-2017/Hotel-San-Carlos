-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-10-2016 a las 04:30:18
-- Versión del servidor: 10.1.16-MariaDB
-- Versión de PHP: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sancarlos2`
--

DELIMITER $$
--
-- Funciones
--
CREATE DEFINER=`root`@`localhost` FUNCTION `generador_correlativo` () RETURNS VARCHAR(10) CHARSET utf8 BEGIN
    DECLARE ultimo_correlativo nvarchar(10) default (SELECT YEAR(curdate()));
    DECLARE vacio int default 0;
    DEClARE correlativo_cursor CURSOR FOR
    SELECT id_bit FROM bitacora ORDER BY id_bit DESC LIMIT 1;
    DECLARE CONTINUE HANDLER
    FOR NOT FOUND SET vacio = 1;
    OPEN correlativo_cursor;
    FETCH correlativo_cursor INTO ultimo_correlativo;
    CLOSE correlativo_cursor;

    IF vacio = 0 THEN
        SET ultimo_correlativo = ultimo_correlativo + 1;
    ELSEIF vacio = 1 THEN
        SET ultimo_correlativo = concat((SELECT YEAR(curdate())),'0001');
    END IF;
    RETURN(ultimo_correlativo);
END$$

CREATE DEFINER=`root`@`localhost` FUNCTION `ValidarContrasena` (`iusuario` NVARCHAR(20), `icon` NVARCHAR(20), `iip` NVARCHAR(20)) RETURNS INT(2) IF EXISTS (select usuario from usuario where iusuario = usuario) THEN
BEGIN
DECLARE psw char(20);
SELECT contrasenia into psw FROM usuario WHERE usuario=iusuario;
	IF icon != psw THEN
	insert into bitacora values(generador_correlativo(),current_time(),curdate(),iusuario,'Fallo loggeo','Login','usuario',iip);
	return 0;
	else
	insert into bitacora values(generador_correlativo(),current_time(),curdate(),iusuario,'Loggeo exitoso','Login','usuario',iip);
	return 1;
	END IF;
END;
ELSE 
return 0;
insert into bitacora values(generador_correlativo(),current_time(),curdate(),iusuario,'Fallo loggeo','Login',iip);
END IF$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion`
--

CREATE TABLE `aplicacion` (
  `id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` char(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `id_bit` varchar(10) NOT NULL,
  `hora` time DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `accion` varchar(100) DEFAULT NULL,
  `tabla` varchar(50) DEFAULT NULL,
  `ip` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`id_bit`, `hora`, `fecha`, `usuario`, `descripcion`, `accion`, `tabla`, `ip`) VALUES
('20160001', '13:50:22', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160002', '13:51:12', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160003', '13:55:53', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160004', '14:03:43', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160005', '14:42:06', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160006', '14:43:56', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160007', '15:04:01', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160008', '15:09:17', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160009', '15:18:01', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160010', '15:18:44', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160011', '15:25:03', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160012', '15:26:58', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160013', '15:27:25', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160014', '15:29:00', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160015', '15:36:51', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8'),
('20160016', '15:39:12', '2016-10-20', 'juan', 'Loggeo exitoso', 'Login', 'usuario', '192.168.1.8');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `id_perfil` int(11) NOT NULL,
  `nombre_perfil` char(40) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_privilegios`
--

CREATE TABLE `perfil_privilegios` (
  `id_aplicacion` int(11) NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `usuario` char(50) NOT NULL,
  `contrasenia` char(80) DEFAULT NULL,
  `fecha_creacion` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `id_empleados_pk` char(10) DEFAULT NULL,
  `id_empresa_pk` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasenia`, `fecha_creacion`, `estado`, `id_empleados_pk`, `id_empresa_pk`) VALUES
('juan', '123', '2016-10-20', 'activo', 'hola', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_privilegios`
--

CREATE TABLE `usuario_privilegios` (
  `usuario` char(50) NOT NULL,
  `id_aplicacion` int(11) NOT NULL,
  `ins` int(11) DEFAULT NULL,
  `sel` int(11) DEFAULT NULL,
  `upd` int(11) DEFAULT NULL,
  `del` int(11) DEFAULT NULL,
  `id_perfil` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario_privilegios`
--

INSERT INTO `usuario_privilegios` (`usuario`, `id_aplicacion`, `ins`, `sel`, `upd`, `del`, `id_perfil`) VALUES
('juan', 100, 1, 0, 0, 0, NULL);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`id_aplicacion`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`id_bit`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`id_perfil`);

--
-- Indices de la tabla `perfil_privilegios`
--
ALTER TABLE `perfil_privilegios`
  ADD PRIMARY KEY (`id_aplicacion`,`id_perfil`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usuario`);

--
-- Indices de la tabla `usuario_privilegios`
--
ALTER TABLE `usuario_privilegios`
  ADD PRIMARY KEY (`usuario`,`id_aplicacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `id_aplicacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `id_perfil` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

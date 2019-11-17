-- MariaDB dump 10.17  Distrib 10.4.6-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: uscsnet
-- ------------------------------------------------------
-- Server version	10.4.6-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cidade`
--

DROP TABLE IF EXISTS `cidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cidade` (
  `Sigla` char(3) NOT NULL,
  `Nome` varchar(20) DEFAULT NULL,
  `Posicao_X` int(11) DEFAULT NULL,
  `Posicao_Y` int(11) DEFAULT NULL,
  PRIMARY KEY (`Sigla`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cidade`
--

LOCK TABLES `cidade` WRITE;
/*!40000 ALTER TABLE `cidade` DISABLE KEYS */;
INSERT INTO `cidade` VALUES ('BAU','BAURU',50,50),('BEL','BELEM',50,50),('BHO','BELO HORIZONTE',50,50),('BLU','BLUMENAU',50,50),('BSB','BRASILIA',50,50),('CMP','CAMPINAS',50,50),('CPG','CAMPO GRANDE',50,50),('CUI','CUIBA',50,50),('CUR','CURITIBA',50,50),('FLO','FLORIANOPOLIS',50,50),('LON','LONDRINA',50,50),('MAN','MANAUS',50,50),('NTL','NATAL',50,50),('POA','PORTO ALEGRE',50,50),('RBP','RIBEIRAO PRETO',50,50),('REC','RECIFE',50,50),('RJO','RIO DE JANEIRO',50,50),('SJC','SAO JOSE DOS CAMPOS',50,50),('SLV','SALVADOR',50,50),('SPO','SAO PAULO',50,50);
/*!40000 ALTER TABLE `cidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vertice`
--

DROP TABLE IF EXISTS `vertice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vertice` (
  `P1_Sigla` char(3) NOT NULL,
  `P2_Sigla` char(3) NOT NULL,
  `Metrica_A` int(11) DEFAULT NULL,
  `Metrica_B` int(11) DEFAULT NULL,
  `Metrica_C` int(11) DEFAULT NULL,
  PRIMARY KEY (`P1_Sigla`,`P2_Sigla`),
  KEY `FK_Vertice_1` (`P2_Sigla`),
  CONSTRAINT `FK_Vertice_0` FOREIGN KEY (`P1_Sigla`) REFERENCES `cidade` (`Sigla`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Vertice_1` FOREIGN KEY (`P2_Sigla`) REFERENCES `cidade` (`Sigla`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vertice`
--

LOCK TABLES `vertice` WRITE;
/*!40000 ALTER TABLE `vertice` DISABLE KEYS */;
INSERT INTO `vertice` VALUES ('BAU','CPG',1,10,13),('BEL','NTL',1,21,3),('BHO','BSB',1,9,6),('BHO','SJC',1,7,8),('BLU','CUR',1,2,5),('BSB','MAN',1,22,6),('BSB','NTL',1,22,7),('CMP','BAU',1,3,6),('CMP','RBP',1,2,4),('CPG','CUI',1,8,2),('CUI','MAN',1,20,3),('CUR','LON',1,6,2),('CUR','SPO',1,5,10),('FLO','BLU',1,1,3),('FLO','CUR',1,2,5),('FLO','RJO',1,12,10),('LON','BAU',1,3,2),('LON','SPO',1,7,2),('MAN','BEL',1,18,2),('NTL','REC',1,4,3),('POA','BLU',1,7,2),('POA','FLO',1,6,2),('RBP','BSB',1,8,4),('REC','SLV',1,8,5),('RJO','BHO',1,7,6),('RJO','SJC',1,3,10),('RJO','SLV',1,20,6),('SJC','CMP',1,2,10),('SLV','NTL',1,15,4),('SPO','CMP',1,1,7),('SPO','RJO',1,5,15),('SPO','SJC',1,2,16);
/*!40000 ALTER TABLE `vertice` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-11-16 20:30:25

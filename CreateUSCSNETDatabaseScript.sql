/* Lógico_1: */

CREATE TABLE Cidade (
    Id_Cidade int AUTO_INCREMENT PRIMARY KEY,
    SIGLA char(3),
    NOME varchar(20),
    Posicao_X int,
    Posicao_Y int
);

CREATE TABLE Conecta (
    P1_Cidade int,
    P2_Cidade int,
    Metrica_A int,
    Metrica_B int,
    Metrica_C int
);
 
ALTER TABLE Conecta ADD CONSTRAINT FK_Conecta_0
    FOREIGN KEY (P1_Cidade)
    REFERENCES Cidade (Id_Cidade)
    ON DELETE CASCADE ON UPDATE CASCADE;
 
ALTER TABLE Conecta ADD CONSTRAINT FK_Conecta_1
    FOREIGN KEY (P2_Cidade)
    REFERENCES Cidade (Id_Cidade)
    ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE cidade AUTO_INCREMENT = 1;
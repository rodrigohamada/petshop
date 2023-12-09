-- Criação do schema
CREATE DATABASE IF NOT EXISTS `petshop`;

-- Usar o schema
USE `petshop`;

-- Tabela de Agendamentos
CREATE TABLE IF NOT EXISTS `agendamento` (
    `ag_codigo` INT AUTO_INCREMENT PRIMARY KEY,
    `ag_data` DATE NOT NULL,
    `ag_horario` TIME NOT NULL,
    `ag_situacao` VARCHAR(15) NOT NULL,
    `ag_animal` INT NOT NULL
);

-- Procedure para adicionar a coluna se não existir
DELIMITER //

CREATE PROCEDURE AddColumnIfNotExists()
BEGIN
    DECLARE columnCount INT;

    -- Verificar se a coluna ag_total já existe na tabela agendamento
    SELECT COUNT(*)
    INTO columnCount
    FROM INFORMATION_SCHEMA.COLUMNS
    WHERE TABLE_SCHEMA = 'petshop'
        AND TABLE_NAME = 'agendamento'
        AND COLUMN_NAME = 'ag_total';

    -- Se a contagem for zero, a coluna não existe e pode ser adicionada
    IF columnCount = 0 THEN
        SET @sql_add_column = 'ALTER TABLE `agendamento` ADD COLUMN `ag_total` DECIMAL(5, 2) DEFAULT 0';
        PREPARE stmt FROM @sql_add_column;
        EXECUTE stmt;
        DEALLOCATE PREPARE stmt;
    END IF;
END //

DELIMITER ;

-- Chamar a procedure para adicionar a coluna
CALL AddColumnIfNotExists();

-- Tabela de Serviços
CREATE TABLE IF NOT EXISTS `servico` (
    `serv_codigo` INT AUTO_INCREMENT PRIMARY KEY,
    `serv_descricao` VARCHAR(50) NOT NULL,
    `serv_preco` DECIMAL(5, 2) NOT NULL,
    `serv_tempo` INT NULL
);

-- Tabela de Raças
CREATE TABLE IF NOT EXISTS `raca` (
    `raca_codigo` INT AUTO_INCREMENT PRIMARY KEY,
    `raca_nome` VARCHAR(50) NOT NULL,
    `raca_pais_origem` VARCHAR(50) NULL
);

-- Tabela de Clientes
CREATE TABLE IF NOT EXISTS `cliente` (
    `cli_codigo` INT AUTO_INCREMENT PRIMARY KEY,
    `cli_nome` VARCHAR(50) NOT NULL,
    `cli_celular` VARCHAR(15) NOT NULL,
    `cli_email` VARCHAR(50) NULL,
    `cli_cpf` CHAR(14) NULL,
    `cli_endereco` VARCHAR(100) NOT NULL,
    `cli_foto` MEDIUMBLOB NULL
);

-- Tabela de Animais
CREATE TABLE IF NOT EXISTS `animal` (
    `ani_codigo` INT AUTO_INCREMENT PRIMARY KEY,
    `ani_nome` VARCHAR(50) NOT NULL,
    `ani_sexo` CHAR(1) NOT NULL,
    `ani_agressivo` CHAR(1) NOT NULL,
    `ani_cor` VARCHAR(25) NOT NULL,
    `ani_idade` INT NOT NULL,
    `ani_alergia` VARCHAR(50) NULL,
    `ani_cliente` INT NOT NULL,
    `ani_raca` INT NOT NULL,
    `ani_foto` MEDIUMBLOB NULL,
    CONSTRAINT `FK_animal_cliente` FOREIGN KEY (`ani_cliente`) REFERENCES `cliente` (`cli_codigo`),
    CONSTRAINT `FK_animal_raca` FOREIGN KEY (`ani_raca`) REFERENCES `raca` (`raca_codigo`)
);

-- Tabela de Agendamentos
CREATE TABLE IF NOT EXISTS `agendamento` (
    `ag_codigo` INT AUTO_INCREMENT PRIMARY KEY,
    `ag_data` DATE NOT NULL,
    `ag_horario` TIME NOT NULL,
    `ag_situacao` VARCHAR(15) NOT NULL,
    `ag_animal` INT NOT NULL
);

-- Chamar a procedure novamente para garantir que a coluna `ag_total` exista
CALL AddColumnIfNotExists();

-- Tabela de Serviços em Agendamentos
CREATE TABLE IF NOT EXISTS `agendamento_servicos` (
    `ag_serv_numero` INT AUTO_INCREMENT PRIMARY KEY,
    `ag_serv_agendamento` INT NOT NULL,
    `ag_serv_servico` INT NOT NULL,
    `ag_serv_quantidade` INT NOT NULL,
    `ag_serv_valor_unitario` DECIMAL(5, 2) NULL,
    CONSTRAINT `FK_agendamento_servicos_servico` FOREIGN KEY (`ag_serv_servico`) REFERENCES `servico` (`serv_codigo`),
    CONSTRAINT `FK_agendamento_servicos_agendamento` FOREIGN KEY (`ag_serv_agendamento`) REFERENCES `agendamento` (`ag_codigo`)
);

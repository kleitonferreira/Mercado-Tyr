create database mercado

use mercado
 
create table usuario
(
	ID_Usuario int not null auto_increment primary key ,
	Nome_Usuario varchar(50) not null  ,
    caixa int,
	Senha_Usuario varchar(20) not null  ,
	Data_Usuario DATETIME not null DEFAULT CURRENT_TIMESTAMP,
	Status_Usuario char(8) not null default 'ATIVO' 
)
UPDATE produto SET quantidade_Produto = quantidade_Produto - 1 where ID_Produto = 1

create table venda
(
	ID_venda int not null auto_increment primary key ,
    pagamento_venda varchar(50) null,
    valor_venda decimal(10, 2) null,
	data_venda DATETIME not null DEFAULT CURRENT_TIMESTAMP,
	status_venda char(20) not null default 'Concluida'

)

ALTER TABLE venda
MODIFY COLUMN data_venda DATETIME DEFAULT CURRENT_TIMESTAMP

create table produto
(
	ID_Produto int not null auto_increment primary key ,
	Nome_Produto varchar(50) not null  ,
	quantidade_Produto varchar(50) not null  ,
    valor_produto decimal(10, 2) not null,
	Status_Produto char(8) not null default 'ATIVO'
    
)

select * from produto

update produto set Status_Produto ='INATIVO' where id_produto =
select ID_Produto, Nome_Produto from produto where quantidade_Produto > 0 and Status_Produto = 'ATIVO'

alter table produto
modify column valor_produto DECIMAL(10, 2)

select * from venda
select * from usuario

update venda set status_venda = 'INATIVO' where id_venda = 2

insert into itens_venda 
(
id_venda_item,
id_produto_item,
id_usuario_item ,
quantidade_produto_item
)values
(
1,
1,
1,
20


)

ALTER TABLE usuario ADD CONSTRAINT UNIQUE (nome_usuario);


CREATE TABLE itens_venda (
    id_item INT PRIMARY KEY AUTO_INCREMENT,
    id_venda_item INT,
    id_produto_item INT,
    id_usuario_item INT,
    nome_usuario_item varchar(50),
    quantidade_produto_item INT,
    
    
    constraint FOREIGN KEY (id_venda_item) REFERENCES venda(id_venda),
	constraint FOREIGN KEY (nome_usuario_item) REFERENCES usuario(nome_usuario),
    constraint FOREIGN KEY (id_usuario_item) REFERENCES usuario(id_usuario),
    constraint FOREIGN KEY (id_produto_item) REFERENCES produto(id_produto)
)

select * from itens_venda
select * from venda
select * from produto where quantidade_Produto > 0
 
INNER JOIN itens_venda where venda.id_venda = 7

delete from venda where ID_venda = 16
delete from itens_venda where id_item = 11

delete from itens_venda where id_item =3

select id_venda_item as 'venda',id_produto_item as 'produto',quantidade_produto_item as 'quantidade' from itens_venda where id_venda_item = 

SELECT 

	venda.data_venda AS 'data',
	venda.status_venda AS 'status',
    itens_venda.nome_usuario_item AS 'operador',
	venda.pagamento_venda AS 'Pagamento',
    venda.valor_venda AS 'total'
    
FROM 
    venda
INNER JOIN 
   itens_venda ON itens_venda.id_venda_item = venda.ID_venda 
WHERE DATE(venda.data_venda) BETWEEN '2025-03-04' AND '2025-03-09' AND venda.status_venda = 'Iniciada' AND itens_venda.id_usuario_item = 1
GROUP BY venda.id_venda

select * from venda 
select * from itens_venda




START TRANSACTION;

SELECT 
    itens_venda.id_venda_item AS 'venda',
    itens_venda.quantidade_produto_item AS 'quantidade',
    produto.Nome_Produto AS 'produto',
    produto.valor_produto AS 'valor'
FROM 
    itens_venda
INNER JOIN 
    produto ON itens_venda.id_produto_item = produto.ID_Produto
WHERE 
    id_venda_item = 53;

UPDATE produto 
SET quantidade_Produto = quantidade_Produto - 1 
WHERE ID_Produto = 1;

COMMIT;

update venda set pagamento_venda = 'Crédito' , valor_venda = '17.00' where id_venda = 8
 

    
    
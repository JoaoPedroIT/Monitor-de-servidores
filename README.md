# Monitor de Servidores

Sistema de monitoramento de servidores desenvolvido em C# para simular coleta de métricas em tempo real e identificar uso crítico de recursos.

Este projeto foi criado como prática para reforçar conceitos importantes de desenvolvimento backend com .NET.

---

## Demonstração

O sistema monitora servidores e exibe informações atualizadas como:

- Uso de CPU
- Uso de Memória
- Status do servidor
- Alertas de uso crítico

Exemplo de saída no console:

Monitor de Servidores
=====================

ID: 1 | Name: Servidor1 | Status: Online | IP: 103.168.0.10  
ID: 2 | Name: Servidor2 | Status: Online | IP: 192.168.0.10  

Alerta: O servidor Servidor1 está com uso crítico de recursos!

---

## Tecnologias utilizadas

- C#
- .NET
- LINQ
- Async / Await
- Console Application

---

## Conceitos aplicados no projeto

Este projeto utiliza conceitos importantes do ecossistema .NET:

- Programação orientada a objetos
- Enum para estados do sistema
- Coleções com List
- LINQ para filtragem de dados
- Programação assíncrona
- Simulação de monitoramento contínuo
- Estrutura de alerta de recursos

---

## Estrutura do projeto

Monitor-de-servidores
│
├── Program.cs
├── Server.cs
└── README.md

---

## Como executar o projeto

Clone o repositório:

git clone https://github.com/seu-usuario/monitor-de-servidores.git

Entre na pasta do projeto:

cd monitor-de-servidores

Execute o projeto:

dotnet run

---

## Objetivo do projeto

Este projeto faz parte do meu processo de evolução como desenvolvedor backend, focando em:

- Aprimorar lógica de programação
- Reforçar conhecimento em C#
- Praticar arquitetura simples de sistemas
- Simular cenários reais de monitoramento

---

## Melhorias futuras

Funcionalidades que podem ser adicionadas:

- Sistema de logs
- Histórico de alertas
- Monitoramento paralelo de servidores
- Persistência de dados em JSON
- API para consulta dos servidores
- Dashboard web
- Sistema de notificações

---

## Autor

João Pedro Isboli Tavares

Estudante de Análise e Desenvolvimento de Sistemas  
Foco em desenvolvimento backend com C# e .NET

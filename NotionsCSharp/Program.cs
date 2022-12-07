using NotionsCSharp.Fundamentos;
using NotionsCSharp.EstruturasDeControle;
using NotionsCSharp.ClassesEMetodos;
using NotionsCSharp.Colecoes;
using NotionsCSharp.OrientacaoObjetos;
using NotionsCSharp.MetodosEFuncoes;
using NotionsCSharp.Excecoes;
using NotionsCSharp.API;
using NotionsCSharp.Consultas;

namespace NotionsCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // Classes & Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Acessar Atributo - Classes e Métodos", AcessarAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Métodos", GettersESetters.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", Enumeracoes.Executar},
                {"Struct - Classes e Métodos", Struct.Executar},
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", ColecoesArray.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // Orientação a Objetos
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OrientacaoObjetos.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed - Orientação a Objetos", Sealed.Executar},
                
                // Métodos & Funções
                {"Lambda - Métodos e Funções", UsandoLambda.Executar},
                {"Lambdas como Delegates - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegates.Executar},
                {"Delegate como Função Anônima - Métodos e Funções", DelegateFuncaoAnonima.Executar},
                {"Delegate como Parâmetro - Métodos e Funções", DelegateComoParametro.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},

                // Exceções
                {"Usando Exceções - Exceções", UsandoExcecoes.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                
                // API
                {"Criando um arquivo - API", CriandoArquivo.Executar},
                {"Lendo um arquivo - API", LendoArquivo.Executar},
                {"Usando FileInfo - API", UsandoFileInfo.Executar},
                {"Diretórios - API", Diretorios.Executar},
                {"Usando DirectoryInfo - API", UsandoDirectoryInfo.Executar},
                {"Usando Path - API", UsandoPath.Executar},
                {"Usando DataTime - API", UsandoDateTime.Executar},
                {"Usando TimeSpan - API", UsandoTimeSpan.Executar},
                
                // Consultas               
                {"LINQ - Consultas", LINQ.Executar},
                {"Nullables - Consultas", Nullables.Executar},
                {"Dynamics - Consultas", Dynamics.Executar},
                {"Generics - Consultas", Genericos.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}

# Estudos c#

# Ordem segerida
##### atributos privados 
            private string _tipo;
            private double _preco;
            private int _quantidade;

##### Propriedades autoimplementadas
            public string Nome { get; set; }
            public string Cor { get; set; }

##### Construtores
            public Pitaya(string tipo, double preco, int quantidade, string nome, string cor)
            {
                _tipo = tipo;
                _preco = preco;
                _quantidade = quantidade;
                Nome = nome;
                Cor = cor;
            }

##### Propriedades Customizadas 
            public double ValorTotal
            {
                get { return _preco * _quantidade; }
            }
    
##### Outros metodos da classe 
            public void AdicionarQuantidade(int quantidade)
            {
                if (quantidade > 0)
                {
                    _quantidade += quantidade;
                    Console.WriteLine($"{quantidade} unidades de {Nome} adicionadas. Total: {_quantidade}.");
                }
                else
                {
                    Console.WriteLine("A quantidade a ser adicionada deve ser maior que zero.");
                }
            }
        
            public void RemoverQuantidade(int quantidade)
            {
                if (quantidade > 0 && quantidade <= _quantidade)
                {
                    _quantidade -= quantidade;
                    Console.WriteLine($"{quantidade} unidades de {Nome} removidas. Total: {_quantidade}.");
                }
                else
                {
                    Console.WriteLine("Quantidade inválida para remoção.");
                }
            }
        
            public void ExibirInformacoes()
            {
                Console.WriteLine($"Tipo: {_tipo}, Nome: {Nome}, Cor: {Cor}, Preço: {_preco:C}, Quantidade: {_quantidade}, Valor Total: {ValorTotal:C}");
            }
        }
        
##### Exemplo de uso da classe
        class Program
        {
            static void Main(string[] args)
            {
                Pitaya pitayaBranca = new Pitaya("Pitaya Branca", 15.00, 10, "Pitaya Branca", "Branca");
        
                // Exibindo informações da pitaya
                pitayaBranca.ExibirInformacoes();
        
                // Adicionando e removendo quantidade
                pitayaBranca.AdicionarQuantidade(5);
                pitayaBranca.RemoverQuantidade(3);
                
                // Exibindo informações após alterações
                pitayaBranca.ExibirInformacoes();
            }
        }

using System;
using System.Collections.Generic;
using System.Linq;

namespace Hikari_Biblioteca.Models
{
    public static class BancoDeDados //static: faz tipo um repositorio
    {
        public static List<Autor> Autores { get; set; } = new List<Autor>
        {
            new Autor {
            Id = 1,
            Nome = "Agatha Christie",
            DataNascimento = new DateTime(1890, 9, 15),
            FotografiaUrl = "/image/agatha.jpg",
            Biografia = "Conhecida como a Rainha do Crime, é a romancista mais bem-sucedida da história da literatura." +
                " Criadora dos detetives Hercule Poirot e Miss Marple, escreveu 66 romances policiais, além de contos e peças de teatro.",
            Curiosidades = "Ela conhecia profundamente venenos por atuar como enfermeira na 1ª Guerra," +
            " desapareceu misteriosamente por 11 dias em 1926, e foi pioneira ao surfar em pé na África do Sul e Havaí."
            },

            new Autor {
            Id = 2,
            Nome = "Isaac Asimov",
            DataNascimento = new DateTime(1920, 1, 2),
            FotografiaUrl = "/image/asimov.jpg",
            Biografia = "Foi um prolífico escritor e bioquímico russo-americano, reconhecido como o pai da ficção científica do século XX.",
            Curiosidades = "Ele criou as famosas \"Três Leis da Robótica\" e cunhou o termo \"robótica\"."
            },

            new Autor {
            Id = 3,
            Nome = "Harper Lee",
            DataNascimento = new DateTime(1926, 4, 28),
            FotografiaUrl = "/image/harper.jpg",
            Biografia = "Foi uma influente escritora norte-americana, célebre pelo romance vencedor do Prêmio Pulitzer," +
            " \"O Sol é para Todos\" (1960). Nascida no Alabama," +
            " Lee teve uma vida reservada e publicou apenas dois romances: o clássico de 1960 e \"Vá, Coloque um Vigia\", lançado em 2015.",
            Curiosidades = "Harper Lee era filha de um advogado e também estudou Direito no Alabama." +
            " Muitos dos personagens em sua obra (O Sol é Para Todos) foram inspirados em pessoas de sua família."
            },

            new Autor {
            Id = 4,
            Nome = "Niklas Natt Och Dag",
            DataNascimento = new DateTime(1970, 10, 3),
            FotografiaUrl = "/image/nikklas.jpg",
            Biografia = "É um escritor sueco renomado por thrillers históricos estreando com o best-seller internacional \"1793\"." +
            " Membro da mais antiga família nobre da Suécia, ele retrata a Estocolmo do final do século XVIII com crueza e precisão," +
            " focando em mistérios sombrios e contextos sociais.",
            Curiosidades = "Em uma entrevista, o autor revelou um \"tabu\" familiar: eles descendem de um famoso assassino sueco, o que influenciou seu interesse pelo lado obscuro da história."
            },

            new Autor {
            Id = 5,
            Nome = "J. R. R. Tolkien",
            DataNascimento = new DateTime(1892, 1, 3),
            FotografiaUrl = "/image/Tolkien.jpg",
            Biografia = "Foi um escritor, professor universitário e filólogo britânico," +
            " nascido na atual África do Sul, que recebeu o título de doutor em Letras e Filologia pela Universidade de Liège e Dublin, em 1954.",
            Curiosidades = "Aos 16 anos, apaixonou-se por Edith Bratt, " +
            " três anos mais velha. Seu tutor proibiu o romance até Tolkien completar 21 anos." +
            " Ele esperou e a pediu em casamento no dia do seu aniversário de 21 anos."
            },

            new Autor {
            Id = 6,
            Nome = "Michael Crichton",
            DataNascimento = new DateTime(1942, 10, 23),
            FotografiaUrl = "/image/michael.jpg",
            Biografia = "Foi um autor, roteirista, diretor de cinema, produtor e médico" +
            " estadunidense mais conhecido por seu trabalho nos gêneros de ficção científica, ficção médica e thriller." +
            " Conhecido como o \"pai do tecnothriller\", vendeu mais de 200 milhões de livros, criando Jurassic Park, Westworld e Congo",
            Curiosidades = "Em 1995, teve simultaneamente o livro, o filme e a série de TV número um nos EUA. "
            }

        };
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        public static List<Livro> Livros { get; set; } = new List<Livro>
        {
            new Livro {
            Id = 1,
            Titulo = "E Não Sobrou Nenhum",
            AutorId = 1,
            Sinopse = "Dez pessoas que não se conhecem são convidadas para uma ilha misteriosa." +
            " Uma a uma, começam a ser assassinadas de acordo com uma antiga cantiga infantil. Quem é o assassino?",
            AnoPublicacao = 1939,
            CapaUrl = "/image/sobrou.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 1)
            },

            new Livro {
            Id = 2,
            Titulo = "O Sol é Para Todos",
            AutorId = 3,
            Sinopse = "É um clássico que aborda racismo, empatia e injustiça social no Alabama dos anos 1930." +
            " Narrado pela criança Scout, mostra seu pai, Atticus Finch, defendendo um homem negro injustamente acusado de estuprar uma mulher branca." +
            " A trama destaca a perda da inocência e a luta moral contra o preconceito arraigado.",
            AnoPublicacao = 1960,
            CapaUrl = "/image/sol.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 3)
            },

            new Livro {
            Id = 3,
            Titulo = "Assassinato no Expresso do Oriente",
            AutorId = 1,
            Sinopse = "O livro acompanha o detetive Hercule Poirot investigando a morte de Samuel Ratchett,"+
            " encontrado com 12 facadas em um trem parado por uma nevasca na Europa."+
            " Poirot descobre que todos os doze passageiros estavam envolvidos na vingança pelo assassinato de uma criança (Daisy Armstrong) cometido por Ratchett no passado. ",
            AnoPublicacao = 1934,
            CapaUrl = "/image/oriente.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 1)
            },

            new Livro {
            Id = 4,
            Titulo = "O Hobbit",
            AutorId = 5,
            Sinopse = "O livro narra a jornada de Bilbo Bolseiro, um hobbit pacato contratado pelo mago Gandalf e treze anões,"+
            " liderados por Thorin Escudo de Carvalho. O grupo busca recuperar um tesouro guardado pelo dragão Smaug na Montanha Solitária." +
            " Bilbo, inicialmente relutante, transforma-se em um herói corajoso," +
            " encontrando o anel mágico de invisibilidade de Gollum e enfrentando trolls, goblins e aranhas.",
            AnoPublicacao = 1937,
            CapaUrl = "/image/hobbit.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 5)
            },

            new Livro {
            Id = 5,
            Titulo = "1793: O Lobo e o Vigia",
            AutorId = 4,
            Sinopse = "A trama segue o advogado doente Cecil Winge e o sentinela Mickel Cardell"+
            " na investigação de um corpo brutalmente mutilado, revelando a corrupção," +
            " desigualdade e a sujeira escondidas sob a superfície da sociedade sueca da época.",
            AnoPublicacao = 2017,
            CapaUrl = "/image/livronikklas.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 4)
            },

            new Livro {
            Id = 6,
            Titulo = "O Fim da Eternidade",
            AutorId = 2,
            Sinopse = "É um clássico de ficção científica sobre Andrew Harlan, um técnico da \"Eternidade\","+
            " organização que viaja no tempo e altera a história para evitar desastres humanos."+
            " A trama de suspense e paradoxos temporais complica-se quando Harlan se apaixona e questiona as mudanças que realiza.",
            AnoPublicacao = 1955,
            CapaUrl = "/image/fim.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 2)
            },

            new Livro {
            Id = 7,
            Titulo = "Morte no Nilo",
            AutorId = 1,
            Sinopse = "Livro clássico de Agatha Christie, acompanha o detetive Hercule Poirot investigando o assassinato"+
            " da herdeira Linnet Doyle durante um cruzeiro de luxo pelo Egito." +
            " Entre passageiros com motivos ocultos e um triângulo amoroso intenso," +
            " Poirot precisa desvendar o crime complexo antes do fim da viagem.",
            AnoPublicacao = 1937,
            CapaUrl = "/image/nilo.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 1)
            },

            new Livro {
            Id = 8,
            Titulo = "Eu, Rôbo",
            AutorId = 2,
            Sinopse = "O livro é uma coletânea literária de contos que ja haviam sido publicados em revistas."+
            " É composto de 10 contos que, de forma sucessiva, discorrem sobre a evolução dos robôs através do tempo.",
            AnoPublicacao = 1950,
            CapaUrl = "/image/robo.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 2)
            },

            new Livro {
            Id = 9,
            Titulo = "Jurassic Park",
            AutorId = 6,
            Sinopse = "O livro é um thriller de ficção científica sobre o colapso de um parque temático na Ilha Nublar,"+
            " onde dinossauros clonados através de engenharia genética escapam." +
            " A trama explora a teoria do caos e os riscos da biotecnologia desenfreada, quando a aventura se torna uma luta pela sobrevivência.",
            AnoPublicacao = 1990,
            CapaUrl = "/image/dino.jpg",
            AutorDoLivro = Autores.FirstOrDefault(a => a.Id == 6)
            }
        };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Isen.DotNet.Library.Models;
using Isen.DotNet.Library.Repositories.Base;
using Isen.DotNet.Library.Repositories.Interfaces;

namespace Isen.DotNet.Library.Repositories.InMemory
{
    public class InMemoryClubRepository :
        BaseInMemoryRepository<Club>,
        IClubRepository
    {      
        public override List<Club> SampleData =>
            new List<Club>()
            {
                new Club() 
                { 
                    Id = 1, Name = "Olympique Lyonnais", 
                    Adresse = "Groupama OL Training Center",
                    GPS="45° 45′ 35″ N,4° 50′ 32″ E", 
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/e/e2/Olympique_lyonnais_%28logo%29.svg/800px-Olympique_lyonnais_%28logo%29.svg.png" 
                },
                new Club() 
                {
                    Id = 2, Name = "EA Guingamp",
                    Adresse = "Stade Fred-Aubert",
                    GPS="48° 30′ 32″ N,2° 44′ 37″ O",
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/9/99/En_Avant_de_Guingamp_logo.svg/1920px-En_Avant_de_Guingamp_logo.svg.png"
                },
                new Club() 
                {
                    Id = 3, Name = "Arsenal WFC", 
                    Adresse = "Meadow Park",
                    GPS="51° 39′ 43″ N,0° 16′ 20″ O", 
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/5/53/Arsenal_FC.svg/800px-Arsenal_FC.svg.png" 
                },
                new Club() 
                {
                    Id = 4, Name = "Montpellier HSC",
                    Adresse = "Stade Jules Rimet",
                    GPS="43° 36′ 43″ N,3° 52′ 38″ E", 
                    Logo="https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Montpellier_H%C3%A9rault_Sport_Club_%28logo%2C_2000%29.svg/480px-Montpellier_H%C3%A9rault_Sport_Club_%28logo%2C_2000%29.svg.png"
                },
                new Club() 
                { 
                    Id = 5, Name = "Paris Saint-Germain",
                    Adresse = "Stade Jean-Bouin" ,
                    GPS="48° 37′ 20″ N,2° 23′ 35″ E",
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/8/86/Paris_Saint-Germain_Logo.svg/480px-Paris_Saint-Germain_Logo.svg.png" 
                },
                new Club() { 
                    Id = 6, Name = "Atlético de Madrid",
                    Adresse = "Cerro del Espino" ,
                    GPS="40° 27′ 27″ N, 3° 51′ 37″ O",
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/9/93/Logo_Atl%C3%A9tico_Madrid_2017.svg/358px-Logo_Atl%C3%A9tico_Madrid_2017.svg.png" 
                },
                new Club() 
                { 
                    Id = 7, Name = "Dijon FCO",
                    Adresse = "Stade Gaston-Gérard" ,
                    GPS="47° 19′ 28″ N, 5° 04′ 06″ E",
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/c/c9/LogoDFCO.svg/440px-LogoDFCO.svg.png" 
                },
                new Club() 
                { 
                    Id = 8, Name = "Paris FC",
                    Adresse = "Stade Charléty" ,
                    GPS="48° 49′ 07″ N, 2° 20′ 47″ E",
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/d/db/Logo_Paris_FC_2011.svg/800px-Logo_Paris_FC_2011.svg.png" 
                },
                new Club() 
                { 
                    Id = 9, Name = "FC Fleury 91",
                    Adresse = "Stade Robert-Bobin" ,
                    GPS="48° 37′ 20″ N, 2° 23′ 35″ E",
                    Logo="https://upload.wikimedia.org/wikipedia/fr/4/40/Logo_Football_Club_Fleury_91_C%C5%93ur_d%27Essonne.png" 
                },
                new Club() {
                    Id = 10, Name = "Girondins de Bordeaux", 
                    Adresse = "Stade Sainte-Germaine",
                    GPS="44° 52′ 15″ N, 0° 37′ 01″ O", 
                    Logo="https://upload.wikimedia.org/wikipedia/fr/thumb/7/76/Logo_des_Girondins_de_Bordeaux.svg/403px-Logo_des_Girondins_de_Bordeaux.svg.png" 
                }
            };
    }
}
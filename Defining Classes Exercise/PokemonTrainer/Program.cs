using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            List<string> trainersNames = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] arr = input.Split(' ').ToArray();
                string trainerName = arr[0];
                string pokemonName = arr[1];
                string element = arr[2];
                int health = int.Parse(arr[3]);
                Trainer trainer = new Trainer(trainerName);
                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                if (!trainersNames.Contains(trainerName))
                {
                    trainersNames.Add(trainerName);
                    trainers.Add(trainer);
                    trainer.Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer currTrainer = trainers.Find(t => t.Name == trainerName);
                    currTrainer.Pokemons.Add(pokemon);
                }
            }

            string cmd;
            List<Pokemon> pokemonsToRemove = new List<Pokemon>();
            while ((cmd = Console.ReadLine()) != "End")
            {
                int counter = 0;
                string el = cmd;
                foreach (var trainer in trainers)
                {
                    List<Pokemon> curr = trainer.Pokemons.ToList();
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == el)
                        {
                            trainer.NumOfBadges++;
                            counter++;
                        }
                    }

                    if (counter == 0)
                    {
                        foreach (var pokemon2 in trainer.Pokemons)
                        {
                            pokemon2.Health -= 10;
                        }
                    }


                    
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Health <= 0)
                        {
                            pokemonsToRemove.Add(pokemon);
                        }
                    }

                    if (pokemonsToRemove.Count > 0)
                    {
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                    //{
                    //    foreach (var pok in curr)
                    //    {
                    //        if (pokemonsToRemove.Contains(pok))
                    //        {
                    //            trainer.Pokemons.Remove(pok);
                    //            pokemonsToRemove.Remove(pok);
                    //        }
                    //    }
                    //}
                    
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumOfBadges))
            {
                Console.Write($"{trainer.Name} {trainer.NumOfBadges} {trainer.Pokemons.Count}");
                Console.WriteLine();
            }
        }
    }
}

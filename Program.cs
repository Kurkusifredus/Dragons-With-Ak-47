using Dragons_With_AK_47;
using System;
using System.Diagnostics;

class Draongs_With_AK_47
{
    static void Main()
    {
        string respuestaDeUsuario;
        bool gameFinished = false;

        Jugador jugador = new Jugador();
        Dragon dragonjs = new Dragon();

        Console.WriteLine("Ante ti, tienes al imponente dragón Javascript, esa mierda se traga todo lo que le eches, así que espero que tengas un buen plan para derrotarlo");
        Console.WriteLine("Empiezas con el Ak-47, un fusil de asalto standart Ruso de sobras conocido, recuerda que su cargador es de 30 balas y tiene 2 modos de fuego, semi y auto");

        do
        {
            Console.WriteLine("1- Disparar.");
            Console.WriteLine("2- Comprobar el cargador actual.");
            Console.WriteLine("3- Meter el mismo cargador.");
            Console.WriteLine("4- Recargar un nuevo cargador.");
            Console.WriteLine("5- Comprobar cuantos cargadores quedan.");
            Console.WriteLine("6- Comprobar cuanta vida te queda.");
            Console.WriteLine("7- Usar una inyección de adrenalina.");
            Console.WriteLine("8- Elegir fuego semiautomático.");
            Console.WriteLine("9- Elegir fuego automático.");
            Console.WriteLine("0- Escapar de la pelea.");

            respuestaDeUsuario = Console.ReadLine();

            switch (respuestaDeUsuario) 
            {
                case "1":

                    if (jugador.balasRestantes > 0 && jugador.fireTypeSemi)
                    {
                        dragonjs.TakeDamage(jugador.GetDamage());
                        jugador.PlayerShoot();
                        jugador.TakeDamage(dragonjs.GetDamage());
                        Console.WriteLine("Disparas con toda la furia de la madre patria al dragón!");
                        Console.WriteLine("Le inflinges 7 puntos de daño al dragón parecen quedarle {0} puntos de vida, ten cuidado.", dragonjs.health);
                        Console.WriteLine("El dragón te golpea con la cola burándose.");
                        Console.WriteLine("Pulsa INTRO para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        if (dragonjs.skillCounter > 0)
                        {
                            dragonjs.DecreaseSkillCounter();
                            dragonjs.Heal();
                            Console.WriteLine("Cuando le disparas mientras usa su aura se cura la mitad del daño que le causas redondeando hacia arriba el muy tramposo!, se nota que sabe sobre recursividad");
                            Console.WriteLine("El dragón tiene actualmente {0} puntos de vida", dragonjs.health);
                            Console.WriteLine("Pulsa INTRO para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if (jugador.balasRestantes > 0 && jugador.fireTypeAuto)
                    {
                        dragonjs.TakeDamage(jugador.GetDamage());
                        jugador.PlayerShoot();
                        jugador.TakeDamage(dragonjs.GetDamage());
                        Console.WriteLine("Disparas como un loco apretando el gatillo con todas tus fuerzas!");
                        Console.WriteLine("Al dragón parecen quedarle {0} puntos de vida, ten cuidado.", dragonjs.health);
                        Console.WriteLine("El dragón escupe fuego y trata de achicharrarte vivo como respuesta.");
                        Console.WriteLine("Pulsa INTRO para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        if (dragonjs.skillCounter > 0)
                        {
                            dragonjs.DecreaseSkillCounter();
                            dragonjs.Heal();
                            Console.WriteLine("Cuando le disparas mientras usa su aura se cura la mitad del daño que le causas redondeando hacia arriba el muy tramposo!, se nota que sabe sobre recursividad");
                            Console.WriteLine("El dragón tiene actualmente {0} puntos de vida", dragonjs.health);
                            Console.WriteLine("Pulsa INTRO para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else 
                    {
                        dragonjs.DecreaseSkillCounter();
                        jugador.mags--;
                        Console.WriteLine("Te has quedado sin munición en el cargador o tienes el seguro puesto, seguro que sabes como funciona un arma?");
                        jugador.TakeDamage(dragonjs.GetDamage());
                        Console.WriteLine("El dragón se rie de ti porque no sabes centrar un /div, lo que te provoca daño emocional");
                        Console.WriteLine("Pulsa INTRO para continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                case "2":

                    dragonjs.DecreaseSkillCounter();
                    Console.WriteLine("Te quedan {0} balas en el cargador.", jugador.balasRestantes);
                    Console.WriteLine("El dragón carga su aliento para doblar su daño, está claro que entiende como funcionan las variables mejor que tú.");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case"3":

                    dragonjs.DecreaseSkillCounter();
                    Console.WriteLine("Vuelves a meter el mismo cargador, te quedan {0} balas.", jugador.balasRestantes);
                    Console.WriteLine("El dragón  termina de cargar su aliento para doblar su daño, yo tendría cuidado con el stack overflow");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "4":

                    dragonjs.DecreaseSkillCounter();
                    jugador.balasRestantes = 30;
                    Console.WriteLine("has insertado un nuevo cargador, recuerda que después de 30 disparos deberás recargar.");
                    Console.WriteLine("El dragón te mira, sabiendo que al final el trabajo será suyo.");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "5":

                    dragonjs.DecreaseSkillCounter();
                    Console.WriteLine("Te quedan {0} cargadores.", jugador.mags);
                    Console.WriteLine("El dragón se ríe de ti porque no sabes utilizar un array para que recuerde cuantas balas te quedan por ti.");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "6":

                    dragonjs.DecreaseSkillCounter();
                    Console.WriteLine("El dragón se rie de ti porque todo lo que programas es demasiado lento, como tu memoria para recordar tu salud.");
                    Console.WriteLine("Te quedan {0} puntos de vida.", jugador.health);
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "7":

                    jugador.Heal(20);
                    dragonjs.usedHashM = true;
                    dragonjs.IncreaseSkillCounter();
                    Console.WriteLine("Te curas 10 puntos de vida. tienes actualmente {0}",jugador.health);
                    Console.WriteLine("Te quedan {0}, jeringuillas de adrenalina.", jugador.chutes);
                    Console.WriteLine("El dragón emite un aura de color cobre a su alrededor, creo que va a utilizar su habilidad secreta, el hash-map.");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "8":

                    dragonjs.DecreaseSkillCounter();
                    dragonjs.SetFireTypeSemi();
                    jugador.SetFireTypeSemi();
                    Console.WriteLine("has cambiado al modo semi-automático.");
                    Console.WriteLine("El dragón golpea con la cola cada vez que le disparas");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "9":

                    dragonjs.DecreaseSkillCounter();
                    dragonjs.SetFireTypeAuto();
                    jugador.SetFireTypeAuto();
                    Console.WriteLine("has cambiado al modo de fuego automático.");
                    Console.WriteLine("El dragón ahora responde con aliento de fuego");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "0":

                    gameFinished = true;
                    Console.WriteLine("Escapas por esta vez, pero el dragón volverá y más te vale estar preparado!");
                    Console.ReadLine();
                    break;

                default: Console.WriteLine("No reconozco esa opción");
                    break;
            }

            if (jugador.health <= 0)
            {
                gameFinished = true;

                Console.WriteLine("Has muerto, pobre de ti, lo mejor será que vuelvas a repasar tus cursillos de HTML...Que vergüenza...");
            }
            else if (dragonjs.health <= 0)
            {
                gameFinished = true;

                Console.WriteLine("Lo has conseguido! Has matado al imponente dragón JavaScript! Ahora podrás ir a conseguirte un trabajo de verdad y dejar de perder el tiempo con los videojuegos! o eso diría una madre al menos no?");
                Console.WriteLine("En fin, muchas gracias por jugar!");
            }
        } while (!gameFinished);
    }
}
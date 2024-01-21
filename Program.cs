using System;
using System.Diagnostics;

class Draongs_With_AK_47
{
    static void Main()
    {
        //const byte DRAGONS_MAXHEALTH = 255, PLAYER_MAXHEALTH = 100, MAX_MAGS = 10. MAX_CHUTES= 3;
        byte playerHealth = 100, currentPlayerHealth, dragonsHealth = 255, currentDragonsHealth;
        byte respuestaDeUsuario, balasRestantes = 30, balasCheck, mags = 10, magsCheck, chutes = 3, chutesactuales, dragonSkillCounter = 0;
        bool fireTypeSemi = false, fireTypeAuto = false, gameFinished = false;

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

            respuestaDeUsuario = Convert.ToByte(Console.ReadLine());

            switch (respuestaDeUsuario) 
            {
                case 1:

                    if (balasRestantes > 0 && fireTypeSemi )
                    {
                        balasRestantes--;
                        dragonsHealth -= 7;
                        currentDragonsHealth = dragonsHealth;
                        Console.WriteLine("Disparas con toda la furia de la madre patria al dragón!");
                        Console.WriteLine("Le inflinges 7 puntos de daño al dragón parecen quedarle {0} puntos de vida, ten cuidado.", currentDragonsHealth);
                        playerHealth -= 10;
                        Console.WriteLine("El dragón te golpea con la cola burándose.");
                        Console.WriteLine("Pulsa INTRO para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        if (dragonSkillCounter > 0)
                        {
                            dragonSkillCounter--;
                            dragonsHealth += 4;
                            Console.WriteLine("Cuando le disparas mientras usa su aura se cura la mitad del daño que le causas redondeando hacia arriba el muy tramposo!, se nota que sabe sobre recursividad");
                            Console.WriteLine("El dragón tiene actualmente {0} puntos de vida", currentDragonsHealth);
                            Console.WriteLine("Pulsa INTRO para continuar");
                            Console.ReadLine();
                            Console.Clear();

                        }
                    }
                    else if (balasRestantes > 0 && fireTypeAuto )
                    {
                        balasRestantes -= 5;
                        dragonsHealth -= 35;
                        currentDragonsHealth = dragonsHealth;
                        Console.WriteLine("Disparas como un loco apretando el gatillo con todas tus fuerzas!");
                        Console.WriteLine("Al dragón parecen quedarle {0} puntos de vida, ten cuidado.", currentDragonsHealth);
                        playerHealth -= 20;
                        Console.WriteLine("El dragón escupe fuego y trata de achicharrarte vivo como respuesta.");
                        Console.WriteLine("Pulsa INTRO para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        if (dragonSkillCounter > 0)
                        {
                            dragonSkillCounter--;
                            dragonsHealth += 18;
                            Console.WriteLine("Cuando le disparas mientras usa su aura se cura la mitad del daño que le causas redondeando hacia arriba el muy tramposo!, se nota que sabe sobre recursividad");
                            Console.WriteLine("El dragón tiene actualmente {0} puntos de vida", currentDragonsHealth);
                            Console.WriteLine("Pulsa INTRO para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else 
                    {
                        balasRestantes = 0;
                        mags--;
                        Console.WriteLine("Te has quedado sin munición en el cargador o tienes el seguro puesto, seguro que sabes como funciona un arma?");
                        playerHealth -= 10;
                        Console.WriteLine("El dragón se rie de ti porque no sabes centrar un /div, lo que te provoca daño emocional");
                        Console.WriteLine("Pulsa INTRO para continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                case 2:
                    balasCheck = balasRestantes;
                    Console.WriteLine("Te quedan {0} balas en el cargador.", balasCheck);
                    Console.WriteLine("El dragón carga su aliento para doblar su daño, está claro que entiende como funcionan las variables mejor que tú.");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    balasCheck = balasRestantes;
                    Console.WriteLine("Vuelves a meter el mismo cargador, te quedan {0} balas.", balasCheck);
                    Console.WriteLine("El dragón  termina de cargar su aliento para doblar su daño, yo tendría cuidado con el stack overflow");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    balasRestantes = 30;
                    Console.WriteLine("has insertado un nuevo cargador, recuerda que después de 30 disparos deberás recargar.");
                    Console.WriteLine("El dragón te mira, sabiendo que al final el trabajo será suyo.");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 5:
                    magsCheck = mags;
                    Console.WriteLine("Te quedan {0} cargadores.", magsCheck);
                    playerHealth -= 10;
                    Console.WriteLine("El dragón se ríe de ti porque no sabes utilizar un aray para que recuerde cuantas balas te quedan por ti.");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 6:
                    currentPlayerHealth = playerHealth;
                    Console.WriteLine("El dragón se rie de ti porque todo lo que programas es demasiado lento, como tu memoria para recordar tu salud.");
                    Console.WriteLine("Te quedan {0} puntos de vida.", currentPlayerHealth);
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 7:
                    chutesactuales = chutes;
                    chutes--;
                    playerHealth += 20;
                    currentPlayerHealth = playerHealth;
                    dragonSkillCounter = 2;
                    Console.WriteLine("Te curas 10 puntos de vida. tienes actualmente {0}", currentPlayerHealth);
                    Console.WriteLine("Te quedan {0}, jeringuillas de adrenalina.", chutesactuales);
                    Console.WriteLine("El dragón emite un aura de color cobre a su alrededor, creo que va a utilizar su habilidad secreta, el hash-map.");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 8:
                    fireTypeSemi = true;
                    fireTypeAuto = false;
                    Console.WriteLine("has cambiado al modo semi-automático.");
                    Console.WriteLine("El dragón golpea con la cola cada vez que le disparas");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 9:
                    fireTypeAuto = true;
                    fireTypeSemi = false;
                    Console.WriteLine("has cambiado al modo de fuego automático.");
                    Console.WriteLine("El dragón ahora responde con aliento de fuego");
                    Console.WriteLine("Pulsa INTRO para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 0:
                    gameFinished = true;
                    Console.WriteLine("Escapas por esta vez, pero el dragón volverá y más te vale estar preparado!");
                    Console.ReadLine();
                    break;

                default: Console.WriteLine("No reconozco esa opción");
                    break;
            }

            if (playerHealth <= 0)
            {
                gameFinished = true;

                Console.WriteLine("Has muerto, pobre de ti, lo mejor será que vuelvas a repasar tus cursillos de HTML...Que vergüenza...");
            }
            else if (dragonsHealth <= 0)
            {
                gameFinished = true;

                Console.WriteLine("Lo has conseguido! Has matado al imponente dragón JavaScript! Ahora podrás ir a conseguirte un trabajo de verdad y dejar de perder el tiempo con los videojuegos! o eso diría una madre al menos no? en fin...");
                Console.WriteLine("Muchas gracias por jugar!");
            }
        } while (!gameFinished);
    }
}
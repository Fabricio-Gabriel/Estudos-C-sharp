﻿using FirstProject.Modelos;

namespace FirstProject.Menus;

internal class MenuSair : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau Tchau ;) ");
    }

}


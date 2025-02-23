﻿using Microsoft.AspNetCore.Mvc.Rendering;

// João Vitor Pedral do Nascimento CB3022391
// Rodrigo Braga Guimarães Brito CB3018105

namespace TP02.Models.Consts;

public static class ConstTamanhoContainer
{
    public static int CONTAINER_20 = 20;
    public static int CONTAINER_40 = 40;

    public static SelectList GetSelectList()
    {
        var tiposContainer = new List<SelectListItem>
            {
                new SelectListItem(CONTAINER_20.ToString(), CONTAINER_20.ToString()),
                new SelectListItem(CONTAINER_40.ToString(), CONTAINER_40.ToString()),
            };

        return new SelectList(tiposContainer, "Value", "Text");
    }
}

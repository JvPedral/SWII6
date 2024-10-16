using Microsoft.AspNetCore.Mvc.Rendering;

// João Vitor Pedral do Nascimento CB3022391
// Rodrigo Braga Guimarães Brito CB3018105

namespace TP02.Models.Consts;

public static class ConstTipoContainer
{
    public static string DRY = "DRY";
    public static string REEFER = "REEFER";

    public static SelectList GetSelectList()
    {
        var tiposContainer = new List<SelectListItem>
            {
                new SelectListItem(DRY, DRY),
                new SelectListItem(REEFER, REEFER),
            };

        return new SelectList(tiposContainer, "Value", "Text");
    }
}

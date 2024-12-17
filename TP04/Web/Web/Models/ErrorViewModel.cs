// João Vitor Pedral CB3022391
// Rodrigo Braga CB3018105

namespace Web.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

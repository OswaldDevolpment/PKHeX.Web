using PKHeX.Core;
using PKHeX.Core.Moves;
using PKHeX.Core.Editing;
using PKHeX.Core.Game;
using PKHeX.Core.Items;
using PKHeX.Core.PKM;
using PKHeX.Core.Util;
using PKHeX.Core.Saves;
using PKHeX.Core.Resources;
using PKHeX.Core.PersonalInfo;
using PKHeX.Drawing;
using PKHeX.Drawing.Misc;
using PKHeX.Drawing.PokeSprite;
using PKHeX.WinForms;

namespace PKHeX.Web.Services
{
  public class PkmEdit
  {
    public bool IsSetLeft { get; set; } = true;

    private PKM _PKM;

    public PKM PKM
    {
      get
      {
        return _PKM;
      }
      set
      {
        _PKM = value;
        NotifyDataChanged();
      }
    }

    public event Action? OnChange;

    public void NotifyDataChanged() => OnChange?.Invoke();
  }
}

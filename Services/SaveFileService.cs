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
using PKHeX.WinForms;

namespace PKHeX.Web.Services
{
  public class SavEdit
  {
    private SaveFile _SAV;

    public SaveFile SAV
    {
      get
      {
        return _SAV;
      }
      set
      {
        _SAV = value;
        GameInfo.FilteredSources = new FilteredGameDataSource(value, GameInfo.Sources);
        NotifyDataChanged();
      }
    }

    public event Action? OnChange;

    public void NotifyDataChanged() => OnChange?.Invoke();
  }
}

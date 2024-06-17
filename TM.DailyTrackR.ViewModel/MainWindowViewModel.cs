namespace TM.DailyTrackR.ViewModel
{
  using Prism.Mvvm;
    using TM.DailyTrackR.Common;
    using TM.DailyTrackR.Logic;

    public sealed class MainWindowViewModel: BindableBase
  {
    public MainWindowViewModel()
    {
            LogicHelper.Instance.ExampleController.DeleteData();
    }
  }
}

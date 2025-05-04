using CommunityToolkit.Mvvm.Input;
using GUI_Projekt_Final.Models;

namespace GUI_Projekt_Final.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}
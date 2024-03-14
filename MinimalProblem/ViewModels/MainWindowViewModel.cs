using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MinimalProblem.ViewModels;

public class Node(string name, ObservableCollection<Node> childNodes)
{
    public string Name { get; set; } = name;
    public ObservableCollection<Node> ChildNodes { get; set; } = childNodes;
}

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private Node _rootNode = new Node("X", new ObservableCollection<Node>
    {
        new Node("Y", new ObservableCollection<Node>()),
        new Node("Z", new ObservableCollection<Node>()),
    });
}
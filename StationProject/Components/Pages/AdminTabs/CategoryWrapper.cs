using StationProject.Data.Models;

namespace StationProject.Components.Pages.AdminTabs;

public class CategoryWrapper(Category category)
{
    public Category Category { get; set; } = category;
    public bool IsExpanded { get; set; } = false;
    public bool IsEditing { get; set; } = false;

}
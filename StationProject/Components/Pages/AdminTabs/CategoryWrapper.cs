using StationProject.Data.Models;

namespace StationProject.Components.Pages.AdminTabs;

public class CategoryWrapper
{
    public Category Category { get; set; }
    public bool IsExpanded { get; set; } = false;
    public bool IsEditing { get; set; } = false;

    public CategoryWrapper(Category category)
    {
        Category = category;
    }
}
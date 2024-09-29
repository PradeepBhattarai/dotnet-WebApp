namespace WebApp.Models;

public static class CategoriesRepository
{
    private static List<Category> _categories=new List<Category>()
    {
        new() {CategoryId=1,Name="Beverage",Description="Beverage isn't good for health."},
        new() {CategoryId=2,Name="Bakery",Description="Bakery"},
        new() {CategoryId=3,Name="Meat",Description="Meat"}
    };
    public static void AddCategory(Category category){
        if(!_categories.Any()){
            category.CategoryId=1;
            _categories.Add(category);
        }
        else{
            var maxId=_categories.Max(x=>x.CategoryId);
        category.CategoryId=maxId+1;
        _categories.Add(category);
        }
    }
    public static List<Category> GetCategories()=>_categories;

    public static Category? GetCategoryById(int categoryId){
        var category=_categories.FirstOrDefault(x=>x.CategoryId==categoryId);
        if(category!=null){
            return new Category{
                CategoryId=category.CategoryId,
                Name=category.Name,
                Description=category.Description,
            };
        }
        return null;
    }

    public static void UpdateCategory(int  categoryId,Category category){
        var categoryToUpdate=_categories.FirstOrDefault(x=>x.CategoryId==categoryId);
        Console.Write(categoryToUpdate);
        if(categoryToUpdate!=null){
            categoryToUpdate.Name=category.Name;
            categoryToUpdate.Description=category.Description;
        }
    }
    public static void DeleteCategory(int categoryId){
        var category=_categories.FirstOrDefault(x=>x.CategoryId==categoryId);
        if(category!=null){
            _categories.Remove(category);
        }
    }
}

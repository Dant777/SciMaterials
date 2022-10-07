namespace SciMaterials.UI.BWASM.Model
{
    public class FileItem
    {
        public string Name { get; set; } = string.Empty;
        public List<FileItem> Files { get; set; } = new List<FileItem>();
        public bool IsFile { get; set; } = false;
    }
}

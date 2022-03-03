namespace PrintingApplication.Presentation.Views.Tentang
{
    public interface ITentangView : IView
    {
        string AssemblyCompany { get; }
        string AssemblyCopyright { get; }
        string AssemblyDescription { get; }
        string AssemblyProduct { get; }
        string AssemblyTitle { get; }
        string AssemblyVersion { get; }

        void ShowView();
    }
}
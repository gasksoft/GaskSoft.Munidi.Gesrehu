Imports System.Web.Optimization
Public Module BundleConfig
    ' Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Content/plugins/jquery/jquery.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
        ' para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Content/plugins/jquery-ui/jquery-ui.min.js",
                  "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                  "~/Content/plugins/chart.js/Chart.min.js",
                  "~/Content/plugins/sparklines/sparkline.js",
                  "~/Content/plugins/jquery-knob/jquery.knob.min.js",
                  "~/Content/plugins/moment/moment.min.js",
                  "~/Content/plugins/daterangepicker/daterangepicker.js",
                  "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                  "~/Content/plugins/summernote/summernote-bs4.min.js",
                  "~/Content/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                  "~/Content/dist/js/adminlte.js",
                  "~/Content/dist/js/pages/dashboard.js",
                  "~/Content/dist/js/demo.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/plugins/fontawesome-free/css/all.min.css",
                  "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                  "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                  "~/Content/dist/css/adminlte.min.css",
                  "~/Content/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                  "~/Content/plugins/daterangepicker/daterangepicker.css",
                  "~/Content/plugins/summernote/summernote-bs4.css"))

    End Sub
End Module


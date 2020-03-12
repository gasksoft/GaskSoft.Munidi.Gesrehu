<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>@ViewBag.Title - SISGRH</title>

    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">

    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body class="hold-transition sidebar-mini layout-fixed">
    <div class="wrapper">
        @Html.Partial("_Navigation")
        @Html.Partial("_Sidebar")

        <div class="content-wrapper">
            @Html.Partial("_Contentheader")
            @RenderBody()
        </div>
        @Html.Partial("_Footer")
        <aside class="control-sidebar control-sidebar-dark">
            <!-- Control sidebar content goes here -->
        </aside>
    </div>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
    <script>
        $.widget.bridge('uibutton', $.ui.button)
    </script>
</body>
</html>

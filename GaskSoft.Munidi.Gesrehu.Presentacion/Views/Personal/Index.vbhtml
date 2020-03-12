@Code
    ViewData("Title") = "Personal"
    ViewData("Namehead") = "Gestión de Personal"
End Code
<section class="content">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
               
                <div class="card card-info">
                    <div class="card-header">
                        <h3 class="card-title">Nuevo Personal</h3>
                    </div>
                    <form action="/" method="post">
                        <div class="card-body">
                            <div class="row">
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label for="idnombre">Nombres: (*)</label>
                                        <div class="input-group">
                                            <input type="text" id="idnombre" class="form-control" placeholder="Nombres">
                                            <div class="input-group-append">
                                                <span class="input-group-text"><i class="fas fa-envelope"></i></span>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="idapellidos">Apellidos: (*)</label>
                                        <div class="input-group">
                                            <input type="text" id="idapellidos" class="form-control" placeholder="Apellidos">
                                            <div class="input-group-append">
                                                <span class="input-group-text"><i class="fas fa-envelope"></i></span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="iddni">DNI: (*)</label>
                                        <div class="input-group">
                                            <input type="text" id="iddni" class="form-control" placeholder="DNI">
                                            <div class="input-group-append">
                                                <span class="input-group-text"><i class="fas fa-envelope"></i></span>
                                            </div>
                                        </div>
                                    </div>

                                </div>

                                <div class="col-md-6">

                                    <div class="form-group">
                                        <label for="iddireccion">Dirección:</label>
                                        <div class="input-group">
                                            <input type="text" id="iddireccion" class="form-control" placeholder="Dirección">
                                            <div class="input-group-append">
                                                <span class="input-group-text"><i class="fas fa-envelope"></i></span>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="iddireccion">Fecha Nacimiento:</label>
                                        <div class="input-group">
                                            <input type="text" id="iddireccion" class="form-control" placeholder="Dirección">
                                            <div class="input-group-append">
                                                <span class="input-group-text"><i class="fas fa-envelope"></i></span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card-footer">
                            <button type="submit" class="btn btn-success" style="margin-right: 15px;">Guardar</button>
                            <button type="submit" class="btn btn-danger">Cancelar</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</section>

<?php
    include("head.php");
?>

<title>When Landslides Strike - B.I.S.Y.</title>
</head>
<body>

<div class="wrapper">
     <?php
        include("sidebar.php");
    ?>

    <div class="main-panel">
    <?php
            include("header.php");
        ?>


        <div class="content">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="header">
                                <h4 class="title">Enter a new LANDSLIDE</h4>
                            </div>
                            <div class="content">

                                <form>
                                    <h5 class="title"><strong>USER INFORMATION</strong></h5> <hr>
                                    <div class="row">
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Name</label>
                                                <input type="text" id="name" class="form-control" placeholder="Name">
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Last Name</label>
                                                <input type="text" id="lastName" class="form-control" placeholder="Last Name">
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Username</label>
                                                <input type="text" id="username" class="form-control" placeholder="Username">
                                            </div>
                                        </div>
                                        <div class="col-md-3">
                                            <div class="form-group">
                                                <label>Email</label>
                                                <input type="text" id="email" class="form-control" placeholder="Email">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label>Address</label>
                                                <input type="text" id="homeAddress" class="form-control" placeholder="Home Address">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label>City</label>
                                                <input type="text" id="city" class="form-control" placeholder="City">
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label>Country</label>
                                                <input type="text" id="country" class="form-control" placeholder="Country">
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label>Postal Code</label>
                                                <input type="number" id="postalCode" class="form-control" placeholder="ZIP Code">
                                            </div>
                                        </div>
                                    </div>
                                    <h5 class="title"><strong>LANDSLIDE INFORMATION</strong></h5><hr>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label>Landslide Address</label>
                                                <input type="text" id="landslideAddress" class="form-control" placeholder="Home Address">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label>Landslide City</label>
                                                <input type="text" id="landslideCity" class="form-control" placeholder="City">
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label>Landslide Country</label>
                                                <input type="text" id="landslideCountry" class="form-control" placeholder="Country">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label>Landslide Type</label>
                                                <input type="text" id="landslideType" class="form-control" placeholder="Type">
                                            </div>
                                        </div>
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label>Landslide Trigger</label>
                                                <input type="text" id="landslideTrigger" class="form-control" placeholder="Trigger">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label>About new landslide </label>
                                                <textarea rows="5" id="landslideInfo" class="form-control" placeholder="Here can be your description"></textarea>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <form action="upload.php" method="post" enctype="multipart/form-data">
                                            Select image to upload:
                                            <input type="file" name="fileToUpload" id="fileToUpload">
                                            <input type="submit" value="Upload Image" name="submit">
                                        </form>
                                        </div>
                                    </div>

                                    <button type="submit" class="btn btn-info btn-fill pull-right">Update</button>
                                    <div class="clearfix"></div>
                                </form>


                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>

       <?php 
        include("footer.php"); 
       ?>

</html>

type = ['','info','success','warning','danger'];

function getCircle(magnitude) {
    return {
      path: google.maps.SymbolPath.CIRCLE,
      fillColor: 'yellow',
      fillOpacity: .8,
      scale: Math.pow(2, magnitude) / 2,
      strokeColor: 'white',
      strokeWeight: .5
    };
};


var myLatlng = new google.maps.LatLng(0.0, 0.0);
  var mapOptions = {
    zoom: 2,
    center: myLatlng,
    scrollwheel: false, //we disable de scroll over the map, it is a really annoing when you scroll through page
    styles: [{"featureType":"water","stylers":[{"saturation":43},{"lightness":-11},{"hue":"#0088ff"}]},{"featureType":"road","elementType":"geometry.fill","stylers":[{"hue":"#ff0000"},{"saturation":-100},{"lightness":99}]},{"featureType":"road","elementType":"geometry.stroke","stylers":[{"color":"#808080"},{"lightness":54}]},{"featureType":"landscape.man_made","elementType":"geometry.fill","stylers":[{"color":"#ece2d9"}]},{"featureType":"poi.park","elementType":"geometry.fill","stylers":[{"color":"#ccdca1"}]},{"featureType":"road","elementType":"labels.text.fill","stylers":[{"color":"#767676"}]},{"featureType":"road","elementType":"labels.text.stroke","stylers":[{"color":"#ffffff"}]},{"featureType":"poi","stylers":[{"visibility":"off"}]},{"featureType":"landscape.natural","elementType":"geometry.fill","stylers":[{"visibility":"on"},{"color":"#b8cb93"}]},{"featureType":"poi.park","stylers":[{"visibility":"on"}]},{"featureType":"poi.sports_complex","stylers":[{"visibility":"on"}]},{"featureType":"poi.medical","stylers":[{"visibility":"on"}]},{"featureType":"poi.business","stylers":[{"visibility":"simplified"}]}]

    };
    var map = null;
demo = {
    initPickColor: function(){
        $('.pick-class-label').click(function(){
            var new_class = $(this).attr('new-class');  
            var old_class = $('#display-buttons').attr('data-class');
            var display_div = $('#display-buttons');
            if(display_div.length) {
            var display_buttons = display_div.find('.btn');
            display_buttons.removeClass(old_class);
            display_buttons.addClass(new_class);
            display_div.attr('data-class', new_class);
            }
        });
    },
    
    initChartist: function(){    
        
        var dataSales = {
          labels: ['9:00AM', '12:00AM', '3:00PM', '6:00PM', '9:00PM', '12:00PM', '3:00AM', '6:00AM'],
          series: [
             [287, 385, 490, 492, 554, 586, 698, 695, 752, 788, 846, 944],
            [67, 152, 143, 240, 287, 335, 435, 437, 539, 542, 544, 647],
            [23, 113, 67, 108, 190, 239, 307, 308, 439, 410, 410, 509]
          ]
        };
        
        var optionsSales = {
          lineSmooth: false,
          low: 0,
          high: 800,
          showArea: true,
          height: "245px",
          axisX: {
            showGrid: false,
          },
          lineSmooth: Chartist.Interpolation.simple({
            divisor: 3
          }),
          showLine: false,
          showPoint: false,
        };
        
        var responsiveSales = [
          ['screen and (max-width: 640px)', {
            axisX: {
              labelInterpolationFnc: function (value) {
                return value[0];
              }
            }
          }]
        ];
    
        Chartist.Line('#chartHours', dataSales, optionsSales, responsiveSales);
    
        var data = {
          labels: ['Rain', 'Construction', 'Continous_rain', 'Dam_Embankment_Collapse', 'Downpour'
          , 'Earthquake', 'Flooding', 'Freeze_thaw', 'Mining_digging', 'Monsoon', 
          'No_Apparent_Trigger', 'Other','Snowfall_snowmelt','Tropical_Cyclone','Unknown','Volcano',''],
          series: [
            [0.200752823, 0.005437056, 0.05823923, 0.000941029, 0.465704726, 
            0.007946466, 0.005123379, 0.002718528, 0.007737348, 0.012965286, 
            0.002091175, 0.001568381,0.007841907,0.056775408,0.085006274,0.000104559,0.079046424]
          ]
        };
        
        var options = {
            seriesBarDistance: 11,
            axisX: {
                showGrid: false
            },
            height: "245px"
        };
        
        var responsiveOptions = [
          ['screen and (max-width: 640px)', {
            seriesBarDistance: 5,
            axisX: {
              labelInterpolationFnc: function (value) {
                return value[0];
              }
            }
          }]
        ];
        
        Chartist.Bar('#chartActivity', data, options, responsiveOptions);
    
        var dataPreferences = {
            series: [
                [25, 30, 20, 25]
            ]
        };
        
        var optionsPreferences = {
            donut: true,
            donutWidth: 40,
            startAngle: 0,
            total: 100,
            showLabel: false,
            axisX: {
                showGrid: false
            }
        };
    
        Chartist.Pie('#chartPreferences', dataPreferences, optionsPreferences);
        
        Chartist.Pie('#chartPreferences', {
          // labels: ['20.08%','5.82%','46.57%','1.3%','5.68%','8.5%','12.03%'],
          series: [20.08,5.82,46.57,1.3,5.68,8.5,12.03]
        });   
    },

  checkPolygon: function(){
    $.ajax({
          url: "https://pmmpublisher.pps.eosdis.nasa.gov/products/global_landslide_nowcast/export/Global/2017/117/global_landslide_nowcast_20170427.geojson"
        })
          .done(function(data) {
            console.log(data);
           
          });
  },
  inside: function(point, vs) {
  var x = point[0], y = point[1];

  var inside = false;
  for (var i = 0, j = vs.length - 1; i < vs.length; j = i++) {
      var xi = vs[i][0], yi = vs[i][1];
      var xj = vs[j][0], yj = vs[j][1];

      var intersect = ((yi > y) != (yj > y))
          && (x < (xj - xi) * (y - yi) / (yj - yi) + xi);
      if (intersect) inside = !inside;
  }
  return inside;
  },

landslideZone: function (myLngInit,myLatInit){
  var point = [myLngInit, myLatInit];
  var nowcast = 0;
  var tekst = "";
  
  $.ajax({
    url: "https://pmmpublisher.pps.eosdis.nasa.gov/products/global_landslide_nowcast/export/Global/2017/117/global_landslide_nowcast_20170427.geojson"
  })
  .done(function(data) {
    console.log(data);
    for(var item in data['features']) {
      var isInside = demo.inside(point,data['features'][item]['geometry']['coordinates'][0]);
      
      if (isInside) {
        nowcast = parseInt(data['features'][item]['properties']['nowcast']);
              
      }

      }
       var tip='info';
        switch(nowcast) {
          case 0: console.log("No Risk"); tekst="No Risk"; break;
          case 1: console.log("Low Risk"); tekst="Low Risk"; tip='warning'; break;
          case 2: console.log("Medium Risk"); tekst="Medium Risk"; tip='danger'; break;
          case 3: console.log("High Risk"); tekst="High Risk"; tip='danger'; break;
        }
        $.notify({
           icon: 'pe-7s-info',
           message: tekst
        },{
            type: tip,
            timer: 4000
        });
  });
},

  initMap: function() {
    console.log("as");
    map = new google.maps.Map(document.getElementById("map"), mapOptions);

  },

  initGoogleMaps: function(lokacijaString, lokacijaPoint){
    var latInit = null;
    var lngInit = null;
    var addrInit = null;

      if(lokacijaString == null){
          if (navigator.geolocation) {
              navigator.geolocation.getCurrentPosition(showPosition);
          } else {
              ad.innerHTML += "Geolocation is not supported by this browser.";
          }
          function showPosition(position) {
            latInit=position.coords.latitude;
            lngInit=position.coords.longitude;
            demo.landslideZone(lngInit,latInit);
              $.ajax({
                url: "https://maps.googleapis.com/maps/api/geocode/json?latlng=" + latInit + "," + lngInit + "&key=AIzaSyAv5mePWBs5PRYlEVVMBD4fHFA45Sk0Iu4"
              })
              .done(function( data ) {
                addrInit = data['results'][0]['formatted_address'];
              });
              var myLatLng2 = new google.maps.LatLng(latInit, lngInit);
              setPoints(myLatLng2);
              // wheaterPredict(latInit, lngInit);
              latInit = null;
              lngInit = null;
          }
      }
      else if (lokacijaPoint == null) {
        $.ajax({
          url: "https://maps.googleapis.com/maps/api/geocode/json?address=" + lokacijaString + "&key=AIzaSyAv5mePWBs5PRYlEVVMBD4fHFA45Sk0Iu4"
        })
          .done(function(data) {
            addrInit = data['results'][0]['formatted_address'];
            latInit = data['results'][0]['geometry']['location']['lat'];
            lngInit = data['results'][0]['geometry']['location']['lng'];
            demo.landslideZone(lngInit,latInit);
            var myLatLng2 = new google.maps.LatLng(latInit, lngInit);
            setPoints(myLatLng2);
            // wheaterPredict(latInit, lngInit);
            latInit = null;
              lngInit = null;
          });

      }

      function setPoints(myPointInit){
        map.setCenter(myPointInit);
        map.setZoom(12);
        var marker = new google.maps.Marker({
            position: myPointInit,
            title:addrInit
        });
        marker.setMap(map);
        $.ajax({
          url: "https://data.nasa.gov/resource/tfkf-kniw.json?$where=within_circle(geolocation," + latInit +"," + lngInit +",50000)"
        })
        .done(function(data) {
          for(var item in data) {
            var trigger = data[item]['trigger'];
            var title = data[item]['near'];
            var nearest_places = data[item]['nearest_places'];
            var lat = data[item]['latitude'];
            var lng = data[item]['longitude'];
            var contentString = '<div id="landslideInfo">'+
                '<div id="siteNotice">'+
                '</div>'+
                '<h1 id="firstHeading" class="firstHeading">Info about this landslide</h1>'+
                '<div id="bodyContent">'+
                '<p><b>Landslide</b>, triggered by: TRIGGER <br>' +
                'with nearest places: NEAREST_PLACES <br>' +
                'NOTE: this will be implemented in the future ' +
                '</div>'+
                '</div>';
            var myLatlng2 = new google.maps.LatLng(lat, lng);
            var mk2 = new google.maps.Marker({
                position: myLatlng2,
                title:title,
                clickable: true,
                map: map,
                icon: getCircle(6)
            });
            var info = new google.maps.InfoWindow();
            google.maps.event.addListener(mk2, 'click', (function(mk2, item) {
              console.log(mk2);
              return function() {
                info.setContent(contentString);
                info.open(map, mk2);
              }
            })(mk2, item));

            google.maps.event.addListener(map, 'click', function() {
              console.log(mk2);
              info.close();
              mk2.open = false;
            });
          }
        });
      }
  },
    
	showNotification: function(from, align){
    	color = Math.floor((Math.random() * 4) + 1);
    	
    	$.notify({
        	icon: "pe-7s-gift",
        	message: "Welcome to <b>Light Bootstrap Dashboard</b> - a beautiful freebie for every web developer."
        	
        },{
            type: type[color],
            timer: 4000,
            placement: {
                from: from,
                align: align
            }
        });
	}   
}
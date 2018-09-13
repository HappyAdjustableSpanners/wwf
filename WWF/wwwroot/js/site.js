// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#form").submit(function () {
	var sigData = $('#signature').jSignature('getData', 'default');

	if (sigData == "data:image/png;base64,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AAECBAgQ6AK/LhSfz+e/x+Pxp69okgABAgQIECDwEQLfr9fr70d8k/glhGKEMkaAAAECBAgQ+KGAUPwhoOcECBAgQIAAAQIfIvDr/lH8EDdfgwABAgQIECBwvYBQvP7EFiRAgAABAgQInAkIxTM3rwgQIECAAAEC1wsIxetPbEECBAgQIECAwJmAUDxz84oAAQIECBAgcL2AULz+xBYkQIAAAQIECJwJCMUzN68IECBAgAABAtcLCMXrT2xBAgQIECBAgMCZgFA8c/OKAAECBAgQIHC9gFC8/sQWJECAAAECBAicCQjFMzevCBAgQIAAAQLXCwjF609sQQIECBAgQIDAmYBQPHPzigABAgQIECBwvYBQvP7EFiRAgAABAgQInAkIxTM3rwgQIECAAAEC1wsIxetPbEECBAgQIECAwJmAUDxz84oAAQIECBAgcL2AULz+xBYkQIAAAQIECJwJCMUzN68IECBAgAABAtcLCMXrT2xBAgQIECBAgMCZgFA8c/OKAAECBAgQIHC9gFC8/sQWJECAAAECBAicCQjFMzevCBAgQIAAAQLXCwjF609sQQIECBAgQIDAmYBQPHPzigABAgQIECBwvYBQvP7EFiRAgAABAgQInAkIxTM3rwgQIECAAAEC1wsIxetPbEECBAgQIECAwJnAf8cBCpeNE/oyAAAAAElFTkSuQmCC") {
		sigData = "";
	}
	
	$('#hiddenSigData').val(sigData);
	console.log('jSignature saving signature');

});





function UpdateAddressDropDown(location) {

	// get addresses for postcode
	var cmd = "https://maps.googleapis.com/maps/api/geocode/json?address=" + location + "&key=AIzaSyCdVwcRvEX2l5d-NY92uVd8Pvo5Uy_ZKCU";

	// for each address, populate the drop down
	$.getJSON(cmd, function (data, textStatus) {
		$('#addressSelectBox').find('option').remove();
		var lat = data.results[0].geometry.location.lat;
		var lng = data.results[0].geometry.location.lng;
		var cmd = "https://maps.googleapis.com/maps/api/geocode/json?latlng=" + lat + "," + lng + "&key=AIzaSyCdVwcRvEX2l5d-NY92uVd8Pvo5Uy_ZKCU";
		$.getJSON(cmd, function (data, textStatus) {
			$.each(data.results, function (key, val) {
				// add to drop down
				var addressSelectBox = document.getElementById("addressSelectBox");
				addressSelectBox.options[addressSelectBox.options.length] = new Option(val.formatted_address);

				// add key value pairs to a hidden element, which we can use later to populate the address fields
				var addressKVPairSelectBox = document.getElementById("addressKVPairSelectBox");
				var kvpairs = "";
				for (i = 0; i < val.address_components.length; i++) {		
					var type = val.address_components[i].types[0];
					var name = val.address_components[i].long_name;
					kvpairs += type + ':' + name + ',';
				}
				addressKVPairSelectBox.options[addressSelectBox.options.length - 1] = new Option(kvpairs);
			});
		});	
	});

	// init address fields to 1st result
}

function PopulateAddressFields(index) {
	var address = $('#addressKVPairSelectBox')[0].options[index].text;

	// reconstruct data
	$('#AddressLine1').val("");


	var fields = address.split(",");

	// for each field
	for (var i = 0; i < fields.length; i++)
	{
		var type = fields[i].split(':')[0];
		var name = fields[i].split(':')[1];
		switch (type)
		{
			case "street_number":
				$('#AddressLine1').val($('#AddressLine1').val() + name + ' ');
				break;
			case "route":
				$('#AddressLine1').val($('#AddressLine1').val() + name);
				break;
			case "locality":
				$('#AddressLine2').val(name);
				break;
			case "administrative_area_level_2":
				$('#AddressLine3').val(name);
				break;
			case "administrative_area_level_1":
				$('#AddressLine4').val(name);
				break;
			case "postal_town":
				$('#Town').val(name);
				break;
			case "country":
				break;
			case "postal_code":
				$('#Postcode').val(name);
				break;
		}
	}

}

$('#PostCodeInput').on('change', function () {
	var location = $('#PostCodeInput').val();

	//populate the address dropdown, and initialise the address fields to the first result
	UpdateAddressDropDown(location);
}); 

$('#addressSelectBox').on('change', function () {
	var location = $('#addressSelectBox').prop('selectedIndex');

	//populate the address dropdown, and initialise the address fields to the first result
	PopulateAddressFields(location);
}); 


// fill out address lines



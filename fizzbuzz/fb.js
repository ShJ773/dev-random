// js
let max_number = process.argv[2];

for(i = 1 ; i <= max_number ; ++i) {

	if ((i % 3 == 0) && (i % 5 == 0)) {
		console.log('fizz buzz');	
	}
	else if (i % 3 == 0) {
		console.log('fizz ');	
	}
	else if (i % 5 == 0) {
		console.log('buzz');	
	}
	else {
		console.log(i);
 	}	
}

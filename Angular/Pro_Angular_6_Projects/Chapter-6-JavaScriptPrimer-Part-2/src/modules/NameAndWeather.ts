

/**	The Contents of the NameAndWeather.ts File **/

export class Name {
	
	constructor(private first: string, private second: string) {
		this.first = first;
		this.second = second;
	}
	
	get nameMessage() : string {
		return `Hello ${this.first} ${this.second}`;
	}
}

export class WeatherLocation {
	
	constructor(private weather: string, private city: string) {
		this.weather = weather;
		this.city = city;
	}
	
	get weatherMessage() : string {
		return `It is ${this.weather} in ${this.city}`;
	}
}



/**	Adding Annotations in the NameAndWeather.ts file Ex. 6-16
export class Name {
	first: string;
	second: string;
	
	constructor(first: string, second: string) {
		this.first = first;
		this.second = second;
	}
	
	get nameMessage() : string {
		return `Hello ${this.first} ${this.second}`;
	}
}

export class WeatherLocation {
	weather: string;
	city: string;
	
	constructor(weather: string, city: string) {
		this.weather = weather;
		this.city = city;
	}
	
	get weatherMessage() : string {
		return `It is ${this.weather} in ${this.city}`;
	}
}
**/













// 1)

function Employee() {
    this.firstName = '';
    this.lastName = '';
    this.salary = 0;
}

Employee.prototype.increseSalary = function () {
    this.salary + 1000;
}

Employee.prototype.info = function () {
    return 'Firs name: ' + this.firstName + ' Last name: ' + this.lastName + ' Salary:' + this.salary;
}

// OR es6


new class Employee {
    constructor() {
        this.fistName = '';
        this.lastName = '';
        this.salary = 0;
    }

    increaseSalary() {
        this.salary + 1000;
    }

    getInfo() {
        return `Firstname: ${this.fistName}, Last name: ${this.lastName}, Salary: ${this.salary}`;
    }
}

// 2)


var mul = (value1) => {
    return (value2) => {
        return (value3) => {
            return (value1 * value2 * value3);
        };
    };
}

console.log(mul(2)(3)(4)); // output : 24 
console.log(mul(4)(3)(4)); // output : 48

// 3)

function longestCountry(countries) {
    return countries.reduce(function (prev, next) {
        if (prev.length > next.length) {
            return prev;
        } else {
            return next;
        }
    });
}

var country = longestCountry(["Australia", "Germany", "United States of America"]);
console.log(country);

// 4)

function removecolor() {
    var $select = $('#colorSelect'),
        $valueToRemove = $select.val();
    if ($select && $valueToRemove) {
        $select.find('option[value="' + $valueToRemove + '"]').remove();
    }
}

// 5)

function insert_Row() {
    var $table = $('#sampleTable'),
        $rowsCount = $table.find('tr').length + 1;

    var $newTr = $('<tr>').append('<td>Row' + $rowsCount + 'cell1</td><td>Row' + $rowsCount + ' cell2</td>');

    $table.find('tr:last').after($newTr[0]);
}

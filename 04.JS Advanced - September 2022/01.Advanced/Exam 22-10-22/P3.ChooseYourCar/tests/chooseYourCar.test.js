let chooseYourCar = require('../chooseYourCar');
let { assert, expect } = require('chai');

describe("Tests For ChooseYourCar", function() { 

    describe("Tests For choosingType function", function() { 
        it("test year", function() { 
            assert.throw(() => chooseYourCar.choosingType('', '', 1000), "Invalid Year!");
            assert.throw(() => chooseYourCar.choosingType('', '', 3000), "Invalid Year!");
        }); 
        it("test type", function() { 
            assert.throw(() => chooseYourCar.choosingType('sss', '', 2000), "This type of car is not what you are looking for.");
        }); 

        it("test1", function() { 
            expect(chooseYourCar.choosingType('Sedan', 'red', 2000)).to.be.equal(`This Sedan is too old for you, especially with that red color.`);
        }); 
        it("test2", function() { 
            expect(chooseYourCar.choosingType('Sedan', 'red', 2010)).to.be.equal(`This red Sedan meets the requirements, that you have.`);
        }); 
        it("test3", function() { 
            expect(chooseYourCar.choosingType('Sedan', 'red', 2020)).to.be.equal(`This red Sedan meets the requirements, that you have.`);
        }); 
    }); 

    describe("Tests For brandName function", function() { 
        it("not arr", function() { 
            assert.throw(() => chooseYourCar.brandName('str', 1), "Invalid Information!");
        }); 
        it("not num", function() { 
            assert.throw(() => chooseYourCar.brandName([], 'str'), "Invalid Information!");
        }); 
        it("not num > arr.length", function() { 
            assert.throw(() => chooseYourCar.brandName([], 1), "Invalid Information!");
        }); 
        it("not num === arr.length", function() { 
            assert.throw(() => chooseYourCar.brandName(['str', 'str'], 2), "Invalid Information!");
        }); 
        it("not num < 0", function() { 
            assert.throw(() => chooseYourCar.brandName([], -1), "Invalid Information!");
        }); 

        it("right test", function() { 
            expect(chooseYourCar.brandName(['str1', 'str2', 'str3 - brandIndex', 'str4'], 2)).to.be.equal('str1, str2, str4');
        }); 
     }); 

     describe("Tests For carFuelConsumption function", function() { 
        it("dis not num", function() { 
            assert.throw(() => chooseYourCar.carFuelConsumption('str', 5), "Invalid Information!");
        }); 
        it("dis num < 0", function() { 
            assert.throw(() => chooseYourCar.carFuelConsumption(-1, 5), "Invalid Information!");
        }); 
        it("dis num === 0", function() { 
            assert.throw(() => chooseYourCar.carFuelConsumption(0, 5), "Invalid Information!");
        }); 
        it("comp not num", function() { 
            assert.throw(() => chooseYourCar.carFuelConsumption(300, 'str'), "Invalid Information!");
        }); 
        it("comp num < 0", function() { 
            assert.throw(() => chooseYourCar.carFuelConsumption(300, -1), "Invalid Information!");
        }); 
        it("comp num === 0", function() { 
            assert.throw(() => chooseYourCar.carFuelConsumption(300, 0), "Invalid Information!");
        }); 
        it("right values 1", function() { 
            expect(chooseYourCar.carFuelConsumption(300, 5)).to.be.equal(`The car is efficient enough, it burns 1.67 liters/100 km.`);
        }); 
        it("right values 2", function() { 
            expect(chooseYourCar.carFuelConsumption(200, 14)).to.be.equal(`The car is efficient enough, it burns 7.00 liters/100 km.`);
        }); 
        it("right values 3", function() { 
            expect(chooseYourCar.carFuelConsumption(200, 16)).to.be.equal(`The car burns too much fuel - 8.00 liters!`);
        }); 
     }); 
}); 
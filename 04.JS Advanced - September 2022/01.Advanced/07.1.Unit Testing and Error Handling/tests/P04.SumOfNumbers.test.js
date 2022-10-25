const { expect } = require("chai");
const sum = require("../P04.SumOfNumbers");

describe('sum', () => {

    it('should return the RIGHT sum of the elements in the array', () => {
        // Arrange
        let arr = [1, 2, 3];

        // Act
        let result = sum(arr);

        // Assert
        expect(result).to.be.equal(6);
    });

});
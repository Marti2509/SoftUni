const { expect } = require("chai");
const isSymmetric = require("../P05.CheckForSymmetry");

describe('isSymmetric', () => {

    it('should return FALSE is it is NOT an array', () => {
        // Arrange
        let notArr = 'not array';

        // Act
        let result = isSymmetric(notArr);

        // Assert
        expect(result).to.be.false;
    });

    it('should return FALSE if the array is NOT symmetrical', () => {
        // Arrange 
        let arr = [1, 2, 3, 4, 3, 2, 2];

        // Act 
        let result = isSymmetric(arr);

        // Assert
        expect(result).to.be.false;
    });

    it('should return TRUE if the array is symmetrical', () => {
        // Arrange 
        let arr = [1, 2, 3, 4, 3, 2, 1];

        // Act 
        let result = isSymmetric(arr);

        // Assert
        expect(result).to.be.true;
    });

    it('should return TRUE if the array is with ONLY one element', () => {
        // Arrange 
        let arr = [1];

        // Act 
        let result = isSymmetric(arr);

        // Assert
        expect(result).to.be.true;
    });

    it('should return TRUE if the array is symmetrical BUT with different types', () => {
        // Arrange 
        let arr = [1, 2, 3, new Date(), 3, 2, 1];

        // Act 
        let result = isSymmetric(arr);

        // Assert
        expect(result).to.be.true;
    });

    it("should return true if the array has more than one DIFFERENT types", () => {
        expect(isSymmetric([5,'hi',{a:5},new Date(),{a:5},'hi',5])).to.be.equal(true);
    });
});
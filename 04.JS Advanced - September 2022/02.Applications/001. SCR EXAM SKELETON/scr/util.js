export function setUserData(data) {
    sessionStorage.setItem('userData', JSON.stringify(data));
}

export function getUserData() {
    const data = JSON.parse(sessionStorage.getItem('userData'));
    return data;
}

export function clearUserDara() {
    sessionStorage.removeItem('userData');
}

// if you want
export function createSubmitHandler(callback) {
    return function(event) {
        event.preventDefault();
        const formData = new FormData(event.target);
        const data = Object.fromEntries(formData);

        callback(data, event.target);
    };
}
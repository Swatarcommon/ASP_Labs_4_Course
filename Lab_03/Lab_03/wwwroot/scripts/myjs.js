function DeleteStudent() {
    fetch('/api/students/?id=' + document.getElementById('id').value, { method: 'DELETE' })
}
function EditStudent() {
    fetch('/api/Values/Put', {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify({
            id: document.getElementById('id').value,
            name: document.getElementById('name').value,
            phone: document.getElementById('phone').value
        })
    })
}
function AddStudent() {
    fetch('/api/students', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify({
            name: document.getElementById('name').value,
            phone: document.getElementById('phone').value
        })
    })
}
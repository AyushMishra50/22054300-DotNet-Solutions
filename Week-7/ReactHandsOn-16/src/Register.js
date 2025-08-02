import React, { useState } from 'react';

function Register() {
  const [form, setForm] = useState({ name: '', email: '', password: '' });
  const [errors, setErrors] = useState({});

  const validate = () => {
    const errors = {};
    if (form.name.length < 5) {
      errors.name = 'Name must be at least 5 characters long.';
    }
    if (!form.email.includes('@') || !form.email.includes('.')) {
      errors.email = 'Email must contain "@" and "."';
    }
    if (form.password.length < 8) {
      errors.password = 'Password must be at least 8 characters long.';
    }
    return errors;
  };

  const handleChange = (e) => {
    setForm({ ...form, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const validationErrors = validate();
    setErrors(validationErrors);

    if (Object.keys(validationErrors).length === 0) {
      alert(`Registration Successful!\nName: ${form.name}\nEmail: ${form.email}`);
      setForm({ name: '', email: '', password: '' });
    }
  };

  return (
    <div style={{ maxWidth: '400px', margin: 'auto', padding: '20px', fontFamily: 'Arial' }}>
      <h2>User Registration</h2>
      <form onSubmit={handleSubmit}>
        <div>
          <label>Name:</label><br />
          <input
            type="text"
            name="name"
            value={form.name}
            onChange={handleChange}
          />
          {errors.name && <p style={{ color: 'red' }}>{errors.name}</p>}
        </div>

        <div>
          <label>Email:</label><br />
          <input
            type="text"
            name="email"
            value={form.email}
            onChange={handleChange}
          />
          {errors.email && <p style={{ color: 'red' }}>{errors.email}</p>}
        </div>

        <div>
          <label>Password:</label><br />
          <input
            type="password"
            name="password"
            value={form.password}
            onChange={handleChange}
          />
          {errors.password && <p style={{ color: 'red' }}>{errors.password}</p>}
        </div>

        <button type="submit" style={{ marginTop: '10px' }}>Register</button>
      </form>
    </div>
  );
}

export default Register;

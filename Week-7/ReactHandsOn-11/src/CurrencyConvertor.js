import React from 'react';

class CurrencyConvertor extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      rupees: '',
      euro: ''
    };
  }

  handleInputChange = (event) => {
    this.setState({ rupees: event.target.value });
  };

  handleSubmit = (event) => {
    event.preventDefault(); // Prevent form reload
    const euroValue = (this.state.rupees / 90).toFixed(2); // Assume 1 Euro = ₹90
    this.setState({ euro: euroValue });
  };

  render() {
    return (
      <div style={{ marginTop: '40px' }}>
        <h2>Currency Convertor</h2>
        <form onSubmit={this.handleSubmit}>
          <input
            type="number"
            placeholder="Enter amount in INR"
            value={this.state.rupees}
            onChange={this.handleInputChange}
          />
          <button type="submit" style={{ marginLeft: '10px' }}>Convert</button>
        </form>
        {this.state.euro && <p>Converted Value in Euro: €{this.state.euro}</p>}
      </div>
    );
  }
}

export default CurrencyConvertor;

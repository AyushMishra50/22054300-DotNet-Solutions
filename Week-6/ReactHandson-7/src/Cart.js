import React from 'react';

class Cart extends React.Component {
  render() {
    return (
      <div>
        <h3>Item: {this.props.itemname}</h3>
        <p>Price: ₹{this.props.price}</p>
        <hr />
      </div>
    );
  }
}

export default Cart;

import * as React from 'react';
import Card from '../card/card';
import './cards.css';

interface IProps {
  values: Array<string>;
}

const Cards: React.FC<IProps> = ({
  values
}) => {
  return (
    <div className="cards">
      {values.map((value) =>
        <Card key={value} value={value}/>
      )}
    </div>
  );
};

export default Cards;

import * as React from 'react';
import Card from '../card/card';
import './cards.css';

interface Props {
  values: Array<string>;
}

const Cards: React.FC<Props> = ({
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

import * as React from 'react';
import './card.css';

interface IProps {
  value: string;
  withoutFocus: boolean;
  selectItem(value:string): void;
}

const Card: React.FC<IProps> = ({
  value,
  selectItem,
  withoutFocus
}) => {
  const select = (val: string) => {selectItem(val)}
  const className = withoutFocus?"cardWithoutFocus":"card";
  switch (value) {
    case 'coffee':
      return <button
      onClick = {() => select('coffee')}
      className={className}>
        <svg width="44" height="44" viewBox="0 0 44 44" fill="none" xmlns="http://www.w3.org/2000/svg">
          <path d="M36.6667 5.5H7.33333V23.8333C7.33333 27.885 10.615 31.1667 14.6667 31.1667H25.6667C29.7183 31.1667 33 27.885 33 23.8333V18.3333H36.6667C38.7017 18.3333 40.3333 16.7017 40.3333 14.6667V9.16667C40.3333 7.13167 38.7017 5.5 36.6667 5.5ZM36.6667 14.6667H33V9.16667H36.6667V14.6667ZM36.6667 38.5H3.66667V34.8333H36.6667V38.5Z" fill="#131B23"/>
        </svg>
      </button>;

    case 'question':
      return <button
      onClick={() => {select('?')}}
      className={className}>?</button>;

    default:
      return <button
      onClick={() => {select(value)}}
      className={className} key={value}>{value}</button>;
  }

};

export default Card;

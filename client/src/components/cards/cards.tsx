import * as React from 'react';
import { connect } from 'react-redux';
import { IRootState } from '../../store/types';
import Card from '../card/card';
import './cards.css';

export interface IProps {
  values: Array<string>;
  onCardSelect(value:string):void;
  selectedItem: string | null;
}

class Cards extends React.Component<IProps> {
  constructor (props: IProps) {
    super(props);
    this.handleCardChange = this.handleCardChange.bind(this);
  }

  public handleCardChange(value: string) {
    this.props.onCardSelect(value)
  }

  public render () {
    const {values} =this.props;

  return (
    <div className="cards">
      {values.map((value) =>
        <Card isSelected={this.props.selectedItem===value} key={value} value={value} selectItem={this.handleCardChange}/>
      )}
    </div>
  );
}}

export default Cards;
// const mapStateToProps = (state: IRootState) => {
//   return {
//     values: state.rooms[0].cards,
//     selectedItem: state.rooms[0].selectedCard
//   }
// }

// export default connect(mapStateToProps)(Cards);

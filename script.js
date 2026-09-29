document.addEventListener('DOMContentLoaded', () => {
  const board = document.querySelector('.board-grid');

  if (board) {
    board.animate(
      [
        { transform: 'scale(0.98)', opacity: 0.8 },
        { transform: 'scale(1)', opacity: 1 }
      ],
      {
        duration: 700,
        easing: 'ease-out'
      }
    );
  }
});

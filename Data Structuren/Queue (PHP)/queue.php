<?php
    class Queue {
        private $queue;

        public function __construct() {
            $this -> queue = array();
        }

        private function GetIndexOfFirstItem() {
            return count( $this -> queue ) - 1;
        }

        public function Enqueue( $item ) {
            array_unshift( $this -> queue, $item );
        }

        public function Peek() {
            return empty( $this -> queue ) ? null : $this -> queue[ $this -> GetIndexOfFirstItem() ];
        }

        public function Dequeue() {
            if ( empty( $this -> queue ) ) {
                return null;
            }

            $firstItem = $this -> Peek();
            unset( $this -> queue[ $this -> GetIndexOfFirstItem() ] );
            return $firstItem;
        }
    }
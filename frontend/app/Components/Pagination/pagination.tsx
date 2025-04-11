'use client'

import { useRouter, useSearchParams } from "next/navigation"
import { FC } from "react";
import styles from "./pagination.module.css"
import { ArrowLeft, ArrowRight } from "lucide-react";

interface PaginationProps {
    hasNextPage: boolean,
    hasPrevPage: boolean
}

// Pagination controls, Display what page you're on and max amount of pages. Will disable button if conditions are met. Followed Youtube guide, Link: https://www.youtube.com/watch?v=SXmni_7B0r4
const Pagination: FC<PaginationProps> = ({
    hasNextPage, hasPrevPage
}) => {
    const router = useRouter();
    const searchParams = useSearchParams();

    const page = searchParams.get('page') ?? '1';
    const perPage = searchParams.get('per_page') ?? '6';

    return (
        <section className={styles.paginationWrapper}>
            <section className={styles.paginationContainer}>
                <button className={styles.paginationButton} disabled={!hasPrevPage} onClick={() =>router.push(`/?page=${Number(page) - 1}&per_page=${perPage}`)}><ArrowLeft/></button>
                <p className={styles.paginationParagraph}>{page} / {Math.ceil(60 / Number(perPage))}</p>
                <button className={styles.paginationButton} disabled={!hasNextPage} onClick={() => router.push(`/?page=${Number(page) + 1}&per_page=${perPage}`)}><ArrowRight/></button>
            </section>
        </section>
    )
}

export default Pagination;